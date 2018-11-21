using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CodeCreate.Code;
using System.Data.SqlClient;
using CommonData.Util.String;
using CommonData.Model.Core;
using System.IO;

namespace CodeCreate
{
    public partial class CodeForm : Form
    {
        public CodeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CodeForm_Load(object sender, EventArgs e)
        {
            
        }


        /// <summary>
        /// 选择登录方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbSQLServer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSQLServer.Checked)
            {
                this.txtUserName.Enabled = true;
                this.txtPassword.Enabled = true;
            }
            else 
            {
                this.txtUserName.Enabled = false;
                this.txtPassword.Enabled = false;
            }
        }

        /// <summary>
        /// 测试连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnection_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlServerName.SelectedItem==null)
                {
                    MessageBox.Show("请选择服务器");
                    return;
                }
                DataTable table = Core.Core.GetDataBase(ddlServerName.SelectedItem.ToString(), txtUserName.Text, txtPassword.Text);
                if (table != null && table.Rows.Count > 0)
                {
                    MessageBox.Show("数据库服务器连接成功");
                    ddlDataBaseName.Items.Clear();
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        ddlDataBaseName.Items.Add(table.Rows[i]["name"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("数据库服务器连接失败");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("数据库服务器连接失败");
                Console.WriteLine(ee.Message);
            }
        }

        /// <summary>
        /// 选择数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ddlDataBaseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetTable();
        }

        private void GetTable()
        {
            try
            {
                DataTable table = Core.Core.GetTable(ddlServerName.SelectedItem.ToString(), ddlDataBaseName.SelectedItem.ToString(), txtUserName.Text, txtPassword.Text);
                ddlTableNames.Items.Clear();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    ddlTableNames.Items.Add(table.Rows[i]["name"].ToString());
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("数据表查询连接发生异常");
                Console.WriteLine(ee.Message);
            }
        }

        /// <summary>
        /// 生成代码
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string servername = ddlServerName.SelectedItem.ToString();
            string dbName = ddlDataBaseName.SelectedItem.ToString();
            string tableName = ddlTableNames.SelectedItem.ToString();
            string connection = null;
            SqlConnection con = null;
            if (rbWindows.Checked)
            {
                connection = "server=" + servername + ";database=" + ddlDataBaseName.SelectedItem.ToString() + ";Integrated Security=true";
            }
            else
            {
                connection = "server=" + servername + ";database=" + ddlDataBaseName.SelectedItem.ToString() + "; uid=" + txtUserName.Text + ";pwd=" + txtPassword.Text;
            }

            try
            {
                con = new SqlConnection(connection);
                con.Open();
                StringBuilder sb = new StringBuilder("select ");
                sb.Append("syscolumns.name as ColName ,");
                sb.Append("systypes.name as ColTypeName ,");
                sb.Append("syscolumns.length,");
                sb.Append("sys.extended_properties.value as Mark ,");
                sb.Append("IsAuto=case ");
                sb.Append("when ( (SELECT COLUMNPROPERTY( OBJECT_ID('" + tableName + "'),'syscolumns.name','IsIdentity')) =1) ");
                sb.Append("then 'true' else 'false' end,");
                sb.Append("AllowNull=case ");
                sb.Append("when (syscolumns.isnullable=0) then 'false' ");
                sb.Append("else 'true' end,");
                sb.Append("IsPK = Case ");
                sb.Append(" when exists ( select 1 from sysobjects inner join sysindexes on sysindexes.name = sysobjects.name inner join sysindexkeys on sysindexes.id = sysindexkeys.id and sysindexes.indid = sysindexkeys.indid where xtype='PK' and parent_obj = syscolumns.id and sysindexkeys.colid = syscolumns.colid )  ");
                sb.Append(" then 'true' else 'false' end ,");
                sb.Append(" IsIdentity = Case syscolumns.status when 128 then 1 else 0 end from syscolumns inner join systypes on ( syscolumns.xtype = systypes.xtype and systypes.name <>'_default_' and systypes.name<>'sysname' ) left outer join sys.extended_properties on ( sys.extended_properties.major_id=syscolumns.id and minor_id=syscolumns.colid ) where syscolumns.id = (select id from sysobjects where name='"+tableName+"')  ");
                sb.Append(" order by syscolumns.colid");
                SqlCommand command = new SqlCommand(sb.ToString(), con);
                SqlDataReader reader = command.ExecuteReader();
                ddlTableNames.Items.Clear();
                StringBuilder sbCode = new StringBuilder("");

                PrintAnnotation(ref sbCode);
                sbCode.Append("\n");

                sbCode.Append("using System;\n");
                sbCode.Append("using System.Collections.Generic;\n");
                sbCode.Append("using System.Linq;\n");
                sbCode.Append("using System.Text;\n");
                sbCode.Append("using System.Data;\n");
                sbCode.Append("using Git.Framework.ORM;\n");
                sbCode.Append("\n");
                sbCode.AppendFormat("namespace Git.Storage.Entity.{0}\n", tbModuleName.Text);
                sbCode.Append("{\n");

                //sbCode.AppendFormat("\t[Serializable]\n");
                sbCode.AppendFormat("\t[TableAttribute(DbName = \"{0}\", Name = \"{1}\", PrimaryKeyName = \"@PrimaryKeyName\", IsInternal = false)]\n", dbName, tableName);
                sbCode.AppendFormat("\tpublic partial class {0}Entity:BaseEntity\n", tbClassName.Text);
                sbCode.Append("\t{\n");
                sbCode.AppendFormat("\t\tpublic {0}Entity()\n", tbClassName.Text);
                sbCode.Append("\t\t{\n");
                sbCode.Append("\t\t}\n\n");
                string pkName="Id";
                while (reader.Read())
                {
                    if(reader["IsPK"].ToString()=="true")
                    {
                        pkName=reader["ColName"].ToString();
                    }
                    sbCode.AppendFormat("\t\t[DataMapping(ColumnName = \"{0}\", DbType = DbType.{1}, Length = {2}, CanNull = {3}, DefaultValue = {4}, PrimaryKey = {5}, AutoIncrement = {6}, IsMap = {7})]\n", 
                        reader["ColName"].ToString(), GetDataType(reader["ColTypeName"].ToString()), reader["length"].ToString(),
                        reader["AllowNull"].ToString(), "null", reader["IsPK"].ToString(), reader["IsAuto"].ToString(), "true");
                    sbCode.AppendFormat("\t\tpublic {0} {1} {{ get; set; }}\n", GetType(reader["ColTypeName"].ToString()), reader["ColName"].ToString().FirstToUpper(reader["ColName"].ToString()));
                    sbCode.Append("\n");

                    sbCode.AppendFormat("\t\tpublic {0}Entity Include{1}(bool flag)\n", tbClassName.Text, reader["ColName"].ToString().FirstToUpper(reader["ColName"].ToString()));
                    sbCode.Append("\t\t{\n");
                    sbCode.AppendFormat("\t\t\tif (flag && !this.ColumnList.Contains(\"{0}\"))\n", reader["ColName"].ToString().FirstToUpper(reader["ColName"].ToString()));
                    sbCode.Append("\t\t\t{\n");
                    sbCode.AppendFormat("\t\t\t\tthis.ColumnList.Add(\"{0}\");\n", reader["ColName"].ToString().FirstToUpper(reader["ColName"].ToString()));
                    sbCode.Append("\t\t\t}\n");
                    sbCode.Append("\t\t\treturn this;\n");
                    sbCode.Append("\t\t}\n");

                    sbCode.Append("\n");
                }
                sbCode.Append("\t}\n");

                sbCode.Append("\n");
                sbCode.Append("\n");

                sbCode.AppendFormat("\tpublic partial class {0}Entity\n", tbClassName.Text);
                sbCode.Append("\t{\n");
                sbCode.Append("\t}\n");

                sbCode.Append("}\n");

                sbCode.Replace("@PrimaryKeyName", pkName);
                rtxtCode.Text = sbCode.ToString();

                PrintIDataAccess();
                PrintDataAccess();
                PrintDataFactory();
            }
            catch(Exception ex)
            {
                MessageBox.Show("连接失败");
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            GetTable();
        }

        private void PrintAnnotation(ref StringBuilder sbCode)
        {
            sbCode.AppendFormat(@"/*******************************************************************************
* Copyright (C) Git Corporation. All rights reserved.
*
* Author: 代码工具自动生成
* Create Date: {0}
*********************************************************************************/", DateTime.Now.ToString("yyyyMMdd"));
        }


        private void PrintIDataAccess()
        {
            StringBuilder sbCode = new StringBuilder("");

            PrintAnnotation(ref sbCode);
            sbCode.Append("\n");

            sbCode.Append("using System;\n");
            sbCode.Append("using System.Collections.Generic;\n");
            sbCode.Append("using System.Linq;\n");
            sbCode.Append("using System.Text;\n");
            sbCode.Append("using System.Data;\n");
            sbCode.Append("using Git.Framework.ORM;\n");
            sbCode.AppendFormat("using Git.Storage.Entity.{0};\n", tbModuleName.Text);
            sbCode.Append("\n");
            sbCode.AppendFormat("namespace Git.Storage.IDataAccess.{0}\n", tbModuleName.Text);
            sbCode.Append("{\n");

            sbCode.AppendFormat("\tpublic partial interface I{0} : IDbHelper<{0}Entity>\n", tbClassName.Text);
            sbCode.Append("\t{\n");
            sbCode.Append("\t}\n");
            sbCode.Append("}");

            rtbIDataAccess.Text = sbCode.ToString();
        }

        private void PrintDataAccess()
        {
            StringBuilder sbCode = new StringBuilder("");

            PrintAnnotation(ref sbCode);
            sbCode.Append("\n");

            sbCode.Append("using System;\n");
            sbCode.Append("using System.Collections.Generic;\n");
            sbCode.Append("using System.Linq;\n");
            sbCode.Append("using System.Text;\n");
            sbCode.Append("using System.Data;\n");
            sbCode.Append("using Git.Framework.ORM;\n");
            sbCode.Append("using Git.Framework.MsSql;\n");
            sbCode.AppendFormat("using Git.Storage.Entity.{0};\n", tbModuleName.Text);
            sbCode.AppendFormat("using Git.Storage.IDataAccess.{0};\n", tbModuleName.Text);
            sbCode.Append("\n");
            sbCode.AppendFormat("namespace Git.Storage.DataAccess.{0}\n", tbModuleName.Text);
            sbCode.Append("{\n");

            sbCode.AppendFormat("\tpublic partial class {0}DataAccess : DbHelper<{0}Entity>, I{0}\n", tbClassName.Text);
            sbCode.Append("\t{\n");
            sbCode.Append("\t}\n");
            sbCode.Append("}");

            rtbDataAccess.Text = sbCode.ToString();
        }

        private void PrintProvider()
        {
            StringBuilder sbCode = new StringBuilder("");

            PrintAnnotation(ref sbCode);
            sbCode.Append("\n");

            sbCode.Append("using System;\n");
            sbCode.Append("using System.Collections.Generic;\n");
            sbCode.Append("using System.Linq;\n");
            sbCode.Append("using System.Text;\n");
            sbCode.Append("using System.Data;\n");
            sbCode.Append("using System.Transactions;\n");
            sbCode.Append("using Git.Framework.Log;\n");
            sbCode.Append("using Git.Framework.DataTypes;\n");
            sbCode.Append("using Git.Framework.DataTypes.ExtensionMethods;\n");
            sbCode.Append("using Git.Framework.ORM;\n");
            sbCode.Append("using Git.Framework.Cache;\n");
            sbCode.Append("using Git.Storage.Common;;\n");
            sbCode.AppendFormat("using Git.Storage.Entity.{0};\n", tbModuleName.Text);
            sbCode.Append("\n");
            sbCode.AppendFormat("namespace Git.Storage.Provider.{0}\n", tbModuleName.Text);
            sbCode.Append("{\n");

            sbCode.AppendFormat("\tpublic partial class {0}Provider : DataFactory\n", tbClassName.Text);
            sbCode.Append("\t{\n");
            sbCode.AppendFormat("\t\tprivate Log log = Log.Instance(typeof({0}Provider));\n", tbClassName.Text);
            sbCode.AppendFormat("\t\tpublic {0}Provider() {{ }}\n", tbClassName.Text);

            sbCode.Append("\t\t/// <summary>\n");
            sbCode.Append("\t\t/// 清除缓存\n");
            sbCode.Append("\t\t/// </summary>\n");
            sbCode.Append("\t\t/// <returns></returns>\n");
            sbCode.Append("\t\tpublic int Clear()\n");
            sbCode.Append("\t\t{\n");
            sbCode.AppendFormat("\t\t\tCacheHelper.Remove(CacheKey.{0}_{1}_CACHE);\n", tbModuleName.Text, tbClassName.Text);
            sbCode.Append("\t\t\treturn 0;\n");
            sbCode.Append("\t\t}\n");

            sbCode.AppendFormat("\t\tpublic int Add({0}Entity entity)\n", tbClassName.Text);
            sbCode.Append("\t\t{\n");
            sbCode.Append("\t\t\tentity.IncludeAll();\n");
            sbCode.AppendFormat("\t\t\tint line = this.{0}.Add(entity);\n", tbClassName.Text);
            sbCode.Append("\t\t\tif (line > 0)\n");
            sbCode.Append("\t\t\t{\n");
            sbCode.Append("\t\t\t\tClear();\n");
            sbCode.Append("\t\t\t}\n");
            sbCode.Append("\t\t\treturn line;\n");
            sbCode.Append("\t\t}\n");

            sbCode.AppendFormat("\t\tpublic int Update({0}Entity entity)\n", tbClassName.Text);
            sbCode.Append("\t\t{\n");
            sbCode.Append("\t\t\tentity.IncludeAll();\n");
            sbCode.AppendFormat("\t\t\tint line = this.{0}.Update(entity);\n", tbClassName.Text);
            sbCode.Append("\t\t\tif (line > 0)\n");
            sbCode.Append("\t\t\t{\n");
            sbCode.Append("\t\t\t\tClear();\n");
            sbCode.Append("\t\t\t}\n");
            sbCode.Append("\t\t\treturn line;\n");
            sbCode.Append("\t\t}\n");

            sbCode.AppendFormat("\t\tpublic int Delete(string {0}Code)\n", tbClassName.Text.FirstToLower(tbClassName.Text));
            sbCode.Append("\t\t{\n");
            sbCode.AppendFormat("\t\t\tint line = this.{0}.Delete(entity);\n", tbClassName.Text);
            sbCode.Append("\t\t\tif (line > 0)\n");
            sbCode.Append("\t\t\t{\n");
            sbCode.Append("\t\t\t\tClear();\n");
            sbCode.Append("\t\t\t}\n");
            sbCode.Append("\t\t\treturn line;\n");
            sbCode.Append("\t\t}\n");

            sbCode.Append("\t}\n");
            sbCode.Append("}");

            rtbNewCode.Text = sbCode.ToString();
        }

        private void PrintDataFactory()
        {
            StringBuilder sbCode = new StringBuilder("");
            sbCode.Append("DataFactory:\n");
            sbCode.AppendFormat("public I{0} {0} {{ get {{ return new {0}DataAccess(); }} }}\n", tbClassName.Text);
            sbCode.Append("\n");
            sbCode.Append("\n");

            sbCode.Append("CacheKey:\n");
            sbCode.AppendFormat("public static string {0}_{1}_CACHE = \"0}_{1}_CACHE\";\n", tbModuleName.Text, tbClassName.Text);
            sbCode.Append("\n");
            sbCode.Append("\n");

            rtbProvider.Text = sbCode.ToString();
        }

        private string GetType(string name)
        {
            string value = "string";
            switch (name)
            { 
                case "int":
                    value = "int";
                    break;
                case "bigint":
                    value = "long";
                    break;
                case "bit":
                    value = "int";
                    break;
                case "char":
                    value = "string";
                    break;
                case "date":
                    value = "DateTime";
                    break;
                case "datetime":
                    value = "DateTime";
                    break;
                case "datetime2":
                    value = "DateTime";
                    break;
                case "float":
                    value = "double";
                    break;
                case "money":
                    value = "double";
                    break;
                case "nchar":
                    value = "string";
                    break;
                case "ntext":
                    value = "string";
                    break;
                case "nvarchar":
                    value = "string";
                    break;
                case "varchar":
                    value = "string";
                    break;
                case "text":
                    value = "string";
                    break;
                
            }
            return value;
        }

        public string GetDataType(string name)
        {
            string value = "Int";
            switch (name.ToLower())
            {
                case "int":
                    value = DbType.Int32.ToString();
                    break;
                case "bigint":
                    value = DbType.Int64.ToString();
                    break;
                case "bit":
                    value = DbType.Byte.ToString();
                    break;
                case "char":
                    value = DbType.String.ToString();
                    break;
                case "date":
                    value = DbType.DateTime.ToString();
                    break;
                case "datetime":
                    value = DbType.DateTime.ToString();
                    break;
                case "datetime2":
                    value = DbType.DateTime.ToString();
                    break;
                case "float":
                    value = DbType.Double.ToString();
                    break;
                case "decimal":
                    value = DbType.Decimal.ToString();
                    break;
                case "money":
                    value = DbType.Currency.ToString();
                    break;
                case "nchar":
                    value = DbType.String.ToString();
                    break;
                case "ntext":
                    value = DbType.String.ToString();
                    break;
                case "nvarchar":
                    value = DbType.String.ToString();
                    break;
                case "varchar":
                    value = DbType.String.ToString();
                    break;
                case "text":
                    value = DbType.String.ToString();
                    break;
            }
            return value;
        }


        /// <summary>
        /// 刷新获取数据库服务名称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //路径设置
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = fbd.SelectedPath + "\\";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tableName = ddlTableNames.Text;
            string pathName = tableName.IndexOf("_") > 0 ? tableName.Split('_')[1] : tableName;

            //创建对应的HTML目录
            if (!Directory.Exists(tbFilePath.Text + pathName))
            {
                Directory.CreateDirectory(tbFilePath.Text + pathName);
            }

            //导出Index
            //using (FileStream aFile = new FileStream(tbFilePath.Text + pathName + "\\Index.cshtml", FileMode.OpenOrCreate))
            //{
            //    using (StreamWriter sw = new StreamWriter(aFile, Encoding.UTF8))
            //    {
            //        sw.WriteLine(txt_Index.Text);
            //    }
            //}
            //导出Create
            //using (FileStream aFile = new FileStream(txtfilepath.Text + pathName + "\\Create.cshtml", FileMode.OpenOrCreate))
            //{
            //    using (StreamWriter sw = new StreamWriter(aFile, Encoding.UTF8))
            //    {
            //        sw.WriteLine(txt_Create.Text);
            //    }
            //}
            //导出Edit
            //using (FileStream aFile = new FileStream(txtfilepath.Text + pathName + "\\Edit.cshtml", FileMode.OpenOrCreate))
            //{
            //    using (StreamWriter sw = new StreamWriter(aFile, Encoding.UTF8))
            //    {
            //        sw.WriteLine(txt_Edit.Text);
            //    }
            //}
            //if (cb_EnableParent.Checked && cb_MulView.Checked)
            //{
            //    //导出CreateParent
            //    using (FileStream aFile = new FileStream(txtfilepath.Text + pathName + "\\CreateParent.cshtml", FileMode.OpenOrCreate))
            //    {
            //        using (StreamWriter sw = new StreamWriter(aFile, Encoding.UTF8))
            //        {
            //            sw.WriteLine(txt_CreateParent.Text);
            //        }
            //    }
            //    //导出EditParent
            //    using (FileStream aFile = new FileStream(txtfilepath.Text + pathName + "\\EditParent.cshtml", FileMode.OpenOrCreate))
            //    {
            //        using (StreamWriter sw = new StreamWriter(aFile, Encoding.UTF8))
            //        {
            //            sw.WriteLine(txt_EditParent.Text);
            //        }
            //    }
            //}
            //导出IDataAccess
            using (FileStream aFile = new FileStream(tbFilePath.Text + "\\I" + tbClassName.Text + ".cs", FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(aFile, Encoding.UTF8))
                {
                    sw.WriteLine(rtbIDataAccess.Text);
                }
            }
            //导出DataAccess
            using (FileStream aFile = new FileStream(tbFilePath.Text + "\\" + tbClassName.Text + "DataAccess.cs", FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(aFile, Encoding.UTF8))
                {
                    sw.WriteLine(rtbDataAccess.Text);
                }
            }
            //导出Model
            using (FileStream aFile = new FileStream(tbFilePath.Text + "\\" + tbClassName.Text + "Entity.cs", FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(aFile, Encoding.UTF8))
                {
                    sw.WriteLine(rtxtCode.Text);
                }
            }
            //导出Controller
            //using (FileStream aFile = new FileStream(txtfilepath.Text + pathName + "Controller.cs", FileMode.OpenOrCreate))
            //{
            //    using (StreamWriter sw = new StreamWriter(aFile, Encoding.UTF8))
            //    {
            //        sw.WriteLine(txt_Controller.Text);
            //    }
            //}

            string path = tbFilePath.Text.Replace("\\\\", "\\");
            System.Diagnostics.Process.Start("explorer.exe", path);
        }

        private void ddlTableNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbClassName.Text = ddlTableNames.Text.FirstToUpper(ddlTableNames.Text);
        }
    }
}
