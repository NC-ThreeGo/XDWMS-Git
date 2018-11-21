namespace CodeCreate
{
    partial class CodeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblServerName = new System.Windows.Forms.Label();
            this.ddlServerName = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.rbSQLServer = new System.Windows.Forms.RadioButton();
            this.rbWindows = new System.Windows.Forms.RadioButton();
            this.gbDataBase = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.ddlDataBaseFile = new System.Windows.Forms.ComboBox();
            this.rbDataBaseFile = new System.Windows.Forms.RadioButton();
            this.ddlDataBaseName = new System.Windows.Forms.ComboBox();
            this.rbDataBaseName = new System.Windows.Forms.RadioButton();
            this.btnConnection = new System.Windows.Forms.Button();
            this.ddlTableNames = new System.Windows.Forms.ComboBox();
            this.lblTableName = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtxtCode = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtbIDataAccess = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtbDataAccess = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rtbNewCode = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbModuleName = new System.Windows.Forms.TextBox();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbClassName = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.rtbProvider = new System.Windows.Forms.RichTextBox();
            this.gbLogin.SuspendLayout();
            this.gbDataBase.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServerName
            // 
            this.lblServerName.Location = new System.Drawing.Point(24, 40);
            this.lblServerName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(108, 42);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "服务器名";
            this.lblServerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ddlServerName
            // 
            this.ddlServerName.FormattingEnabled = true;
            this.ddlServerName.Items.AddRange(new object[] {
            "."});
            this.ddlServerName.Location = new System.Drawing.Point(28, 88);
            this.ddlServerName.Margin = new System.Windows.Forms.Padding(6);
            this.ddlServerName.Name = "ddlServerName";
            this.ddlServerName.Size = new System.Drawing.Size(328, 32);
            this.ddlServerName.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(372, 80);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 56);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.txtPassword);
            this.gbLogin.Controls.Add(this.txtUserName);
            this.gbLogin.Controls.Add(this.lblPassword);
            this.gbLogin.Controls.Add(this.lblUserName);
            this.gbLogin.Controls.Add(this.rbSQLServer);
            this.gbLogin.Controls.Add(this.rbWindows);
            this.gbLogin.Location = new System.Drawing.Point(28, 160);
            this.gbLogin.Margin = new System.Windows.Forms.Padding(6);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Padding = new System.Windows.Forms.Padding(6);
            this.gbLogin.Size = new System.Drawing.Size(494, 258);
            this.gbLogin.TabIndex = 4;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "登录到服务器";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(140, 192);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(312, 35);
            this.txtPassword.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(140, 134);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(6);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(312, 35);
            this.txtUserName.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(44, 198);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 36);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "密  码";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(44, 140);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(82, 36);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "用户名";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbSQLServer
            // 
            this.rbSQLServer.AutoSize = true;
            this.rbSQLServer.Location = new System.Drawing.Point(12, 84);
            this.rbSQLServer.Margin = new System.Windows.Forms.Padding(6);
            this.rbSQLServer.Name = "rbSQLServer";
            this.rbSQLServer.Size = new System.Drawing.Size(329, 28);
            this.rbSQLServer.TabIndex = 1;
            this.rbSQLServer.Text = "使用 SQL Server 身份验证";
            this.rbSQLServer.UseVisualStyleBackColor = true;
            this.rbSQLServer.CheckedChanged += new System.EventHandler(this.rbSQLServer_CheckedChanged);
            // 
            // rbWindows
            // 
            this.rbWindows.AutoSize = true;
            this.rbWindows.Checked = true;
            this.rbWindows.Location = new System.Drawing.Point(12, 40);
            this.rbWindows.Margin = new System.Windows.Forms.Padding(6);
            this.rbWindows.Name = "rbWindows";
            this.rbWindows.Size = new System.Drawing.Size(293, 28);
            this.rbWindows.TabIndex = 0;
            this.rbWindows.TabStop = true;
            this.rbWindows.Text = "使用 Windows 身份验证";
            this.rbWindows.UseVisualStyleBackColor = true;
            // 
            // gbDataBase
            // 
            this.gbDataBase.Controls.Add(this.txtName);
            this.gbDataBase.Controls.Add(this.lblName);
            this.gbDataBase.Controls.Add(this.ddlDataBaseFile);
            this.gbDataBase.Controls.Add(this.rbDataBaseFile);
            this.gbDataBase.Controls.Add(this.ddlDataBaseName);
            this.gbDataBase.Controls.Add(this.rbDataBaseName);
            this.gbDataBase.Location = new System.Drawing.Point(28, 454);
            this.gbDataBase.Margin = new System.Windows.Forms.Padding(6);
            this.gbDataBase.Name = "gbDataBase";
            this.gbDataBase.Padding = new System.Windows.Forms.Padding(6);
            this.gbDataBase.Size = new System.Drawing.Size(494, 356);
            this.gbDataBase.TabIndex = 5;
            this.gbDataBase.TabStop = false;
            this.gbDataBase.Text = "链接一个数据库";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(48, 290);
            this.txtName.Margin = new System.Windows.Forms.Padding(6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(404, 35);
            this.txtName.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(44, 238);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 46);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "逻辑名";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ddlDataBaseFile
            // 
            this.ddlDataBaseFile.Enabled = false;
            this.ddlDataBaseFile.FormattingEnabled = true;
            this.ddlDataBaseFile.Location = new System.Drawing.Point(48, 180);
            this.ddlDataBaseFile.Margin = new System.Windows.Forms.Padding(6);
            this.ddlDataBaseFile.Name = "ddlDataBaseFile";
            this.ddlDataBaseFile.Size = new System.Drawing.Size(404, 32);
            this.ddlDataBaseFile.TabIndex = 8;
            // 
            // rbDataBaseFile
            // 
            this.rbDataBaseFile.AutoSize = true;
            this.rbDataBaseFile.Location = new System.Drawing.Point(12, 136);
            this.rbDataBaseFile.Margin = new System.Windows.Forms.Padding(6);
            this.rbDataBaseFile.Name = "rbDataBaseFile";
            this.rbDataBaseFile.Size = new System.Drawing.Size(257, 28);
            this.rbDataBaseFile.TabIndex = 7;
            this.rbDataBaseFile.Text = "附加一个数据库文档";
            this.rbDataBaseFile.UseVisualStyleBackColor = true;
            // 
            // ddlDataBaseName
            // 
            this.ddlDataBaseName.FormattingEnabled = true;
            this.ddlDataBaseName.Location = new System.Drawing.Point(48, 84);
            this.ddlDataBaseName.Margin = new System.Windows.Forms.Padding(6);
            this.ddlDataBaseName.Name = "ddlDataBaseName";
            this.ddlDataBaseName.Size = new System.Drawing.Size(404, 32);
            this.ddlDataBaseName.TabIndex = 6;
            this.ddlDataBaseName.SelectedIndexChanged += new System.EventHandler(this.ddlDataBaseName_SelectedIndexChanged);
            // 
            // rbDataBaseName
            // 
            this.rbDataBaseName.AutoSize = true;
            this.rbDataBaseName.Checked = true;
            this.rbDataBaseName.Location = new System.Drawing.Point(12, 40);
            this.rbDataBaseName.Margin = new System.Windows.Forms.Padding(6);
            this.rbDataBaseName.Name = "rbDataBaseName";
            this.rbDataBaseName.Size = new System.Drawing.Size(305, 28);
            this.rbDataBaseName.TabIndex = 1;
            this.rbDataBaseName.TabStop = true;
            this.rbDataBaseName.Text = "选择或输入一个数据库名";
            this.rbDataBaseName.UseVisualStyleBackColor = true;
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(28, 822);
            this.btnConnection.Margin = new System.Windows.Forms.Padding(6);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(150, 58);
            this.btnConnection.TabIndex = 6;
            this.btnConnection.Text = "测试连接";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // ddlTableNames
            // 
            this.ddlTableNames.FormattingEnabled = true;
            this.ddlTableNames.Location = new System.Drawing.Point(658, 88);
            this.ddlTableNames.Margin = new System.Windows.Forms.Padding(6);
            this.ddlTableNames.Name = "ddlTableNames";
            this.ddlTableNames.Size = new System.Drawing.Size(328, 32);
            this.ddlTableNames.TabIndex = 8;
            this.ddlTableNames.SelectedIndexChanged += new System.EventHandler(this.ddlTableNames_SelectedIndexChanged);
            // 
            // lblTableName
            // 
            this.lblTableName.Location = new System.Drawing.Point(564, 88);
            this.lblTableName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(82, 36);
            this.lblTableName.TabIndex = 6;
            this.lblTableName.Text = "表  名";
            this.lblTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(1834, 68);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(150, 56);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "生成";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(568, 160);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1488, 656);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtxtCode);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1472, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "实体";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtxtCode
            // 
            this.rtxtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtCode.Location = new System.Drawing.Point(3, 3);
            this.rtxtCode.Margin = new System.Windows.Forms.Padding(6);
            this.rtxtCode.Name = "rtxtCode";
            this.rtxtCode.Size = new System.Drawing.Size(1466, 603);
            this.rtxtCode.TabIndex = 9;
            this.rtxtCode.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtbIDataAccess);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1472, 609);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "IDataAccess";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtbIDataAccess
            // 
            this.rtbIDataAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbIDataAccess.Location = new System.Drawing.Point(0, 0);
            this.rtbIDataAccess.Margin = new System.Windows.Forms.Padding(6);
            this.rtbIDataAccess.Name = "rtbIDataAccess";
            this.rtbIDataAccess.Size = new System.Drawing.Size(1472, 609);
            this.rtbIDataAccess.TabIndex = 10;
            this.rtbIDataAccess.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtbDataAccess);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1472, 609);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DataAccess";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtbDataAccess
            // 
            this.rtbDataAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDataAccess.Location = new System.Drawing.Point(0, 0);
            this.rtbDataAccess.Margin = new System.Windows.Forms.Padding(6);
            this.rtbDataAccess.Name = "rtbDataAccess";
            this.rtbDataAccess.Size = new System.Drawing.Size(1472, 609);
            this.rtbDataAccess.TabIndex = 10;
            this.rtbDataAccess.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rtbNewCode);
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1472, 609);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "增加的代码行";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rtbNewCode
            // 
            this.rtbNewCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNewCode.Location = new System.Drawing.Point(0, 0);
            this.rtbNewCode.Margin = new System.Windows.Forms.Padding(6);
            this.rtbNewCode.Name = "rtbNewCode";
            this.rtbNewCode.Size = new System.Drawing.Size(1472, 609);
            this.rtbNewCode.TabIndex = 11;
            this.rtbNewCode.Text = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1036, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "模块名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbModuleName
            // 
            this.tbModuleName.Location = new System.Drawing.Point(1130, 88);
            this.tbModuleName.Margin = new System.Windows.Forms.Padding(6);
            this.tbModuleName.Name = "tbModuleName";
            this.tbModuleName.Size = new System.Drawing.Size(272, 35);
            this.tbModuleName.TabIndex = 12;
            // 
            // tbFilePath
            // 
            this.tbFilePath.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbFilePath.Location = new System.Drawing.Point(671, 836);
            this.tbFilePath.Margin = new System.Windows.Forms.Padding(6);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(1005, 35);
            this.tbFilePath.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.Location = new System.Drawing.Point(585, 833);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "目录";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(1688, 825);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 56);
            this.button1.TabIndex = 15;
            this.button1.Text = "选择";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(1882, 823);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 56);
            this.button2.TabIndex = 16;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1431, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 36);
            this.label3.TabIndex = 11;
            this.label3.Text = "类名";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbClassName
            // 
            this.tbClassName.Location = new System.Drawing.Point(1525, 85);
            this.tbClassName.Margin = new System.Windows.Forms.Padding(6);
            this.tbClassName.Name = "tbClassName";
            this.tbClassName.Size = new System.Drawing.Size(272, 35);
            this.tbClassName.TabIndex = 12;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.rtbProvider);
            this.tabPage5.Location = new System.Drawing.Point(8, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1472, 609);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Provider";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // rtbProvider
            // 
            this.rtbProvider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbProvider.Location = new System.Drawing.Point(0, 0);
            this.rtbProvider.Margin = new System.Windows.Forms.Padding(6);
            this.rtbProvider.Name = "rtbProvider";
            this.rtbProvider.Size = new System.Drawing.Size(1472, 609);
            this.rtbProvider.TabIndex = 11;
            this.rtbProvider.Text = "";
            // 
            // CodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2068, 904);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbClassName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbModuleName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.ddlTableNames);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.gbDataBase);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.ddlServerName);
            this.Controls.Add(this.lblServerName);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "情缘-代码生成器";
            this.Load += new System.EventHandler(this.CodeForm_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbDataBase.ResumeLayout(false);
            this.gbDataBase.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.ComboBox ddlServerName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.RadioButton rbWindows;
        private System.Windows.Forms.RadioButton rbSQLServer;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox gbDataBase;
        private System.Windows.Forms.RadioButton rbDataBaseFile;
        private System.Windows.Forms.ComboBox ddlDataBaseName;
        private System.Windows.Forms.RadioButton rbDataBaseName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox ddlDataBaseFile;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.ComboBox ddlTableNames;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox rtxtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbModuleName;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbClassName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtbIDataAccess;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtbDataAccess;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox rtbNewCode;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.RichTextBox rtbProvider;
    }
}