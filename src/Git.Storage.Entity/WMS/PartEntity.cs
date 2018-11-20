/*******************************************************************************
* Copyright (C) Git Corporation. All rights reserved.
*
* Author: 代码工具自动生成
* Create Date: 20181120
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Git.Framework.ORM;

namespace Git.Storage.Entity.WMS
{
	[TableAttribute(DbName = "XDWMS-Git", Name = "WMS_Part", PrimaryKeyName = "Id", IsInternal = false)]
	public partial class PartEntity:BaseEntity
	{
		public PartEntity()
		{
		}

		[DataMapping(ColumnName = "ID", DbType = DbType.Int32, Length = 4, CanNull = false, DefaultValue = null, PrimaryKey = false, AutoIncrement = false, IsMap = true)]
		public int ID { get; set; }

		public PartEntity IncludeID(bool flag)
		{
			if (flag && !this.ColumnList.Contains("ID"))
			{
				this.ColumnList.Add("ID");
			}
			return this;
		}

		[DataMapping(ColumnName = "PartID", DbType = DbType.String, Length = 20, CanNull = false, DefaultValue = null, PrimaryKey = false, AutoIncrement = false, IsMap = true)]
		public string PartID { get; set; }

		public PartEntity IncludePartID(bool flag)
		{
			if (flag && !this.ColumnList.Contains("PartID"))
			{
				this.ColumnList.Add("PartID");
			}
			return this;
		}

		[DataMapping(ColumnName = "PartCode", DbType = DbType.String, Length = 100, CanNull = false, DefaultValue = null, PrimaryKey = false, AutoIncrement = false, IsMap = true)]
		public string PartCode { get; set; }

		public PartEntity IncludePartCode(bool flag)
		{
			if (flag && !this.ColumnList.Contains("PartCode"))
			{
				this.ColumnList.Add("PartCode");
			}
			return this;
		}

		[DataMapping(ColumnName = "PartName", DbType = DbType.String, Length = 400, CanNull = false, DefaultValue = null, PrimaryKey = false, AutoIncrement = false, IsMap = true)]
		public string PartName { get; set; }

		public PartEntity IncludePartName(bool flag)
		{
			if (flag && !this.ColumnList.Contains("PartName"))
			{
				this.ColumnList.Add("PartName");
			}
			return this;
		}

		[DataMapping(ColumnName = "PartType", DbType = DbType.String, Length = 20, CanNull = true, DefaultValue = null, PrimaryKey = false, AutoIncrement = false, IsMap = true)]
		public string PartType { get; set; }

		public PartEntity IncludePartType(bool flag)
		{
			if (flag && !this.ColumnList.Contains("PartType"))
			{
				this.ColumnList.Add("PartType");
			}
			return this;
		}

		[DataMapping(ColumnName = "CustomerCode", DbType = DbType.String, Length = 100, CanNull = true, DefaultValue = null, PrimaryKey = false, AutoIncrement = false, IsMap = true)]
		public string CustomerCode { get; set; }

		public PartEntity IncludeCustomerCode(bool flag)
		{
			if (flag && !this.ColumnList.Contains("CustomerCode"))
			{
				this.ColumnList.Add("CustomerCode");
			}
			return this;
		}

		[DataMapping(ColumnName = "LogisticsCode", DbType = DbType.String, Length = 100, CanNull = true, DefaultValue = null, PrimaryKey = false, AutoIncrement = false, IsMap = true)]
		public string LogisticsCode { get; set; }

		public PartEntity IncludeLogisticsCode(bool flag)
		{
			if (flag && !this.ColumnList.Contains("LogisticsCode"))
			{
				this.ColumnList.Add("LogisticsCode");
			}
			return this;
		}

		[DataMapping(ColumnName = "OtherCode", DbType = DbType.String, Length = 100, CanNull = true, DefaultValue = null, PrimaryKey = false, AutoIncrement = false, IsMap = true)]
		public string OtherCode { get; set; }

		public PartEntity IncludeOtherCode(bool flag)
		{
			if (flag && !this.ColumnList.Contains("OtherCode"))
			{
				this.ColumnList.Add("OtherCode");
			}
			return this;
		}

		[DataMapping(ColumnName = "Pcs", DbType = DbType.Decimal, Length = 9, CanNull = true, DefaultValue = null, PrimaryKey = false, AutoIncrement = false, IsMap = true)]
		public string Pcs { get; set; }

		public PartEntity IncludePcs(bool flag)
		{
			if (flag && !this.ColumnList.Contains("Pcs"))
			{
				this.ColumnList.Add("Pcs");
			}
			return this;
		}

		[DataMapping(ColumnName = "StoreMan", DbType = DbType.String, Length = 100, CanNull = true, DefaultValue = null, PrimaryKey = false, AutoIncrement = false, IsMap = true)]
		public string StoreMan { get; set; }

		public PartEntity IncludeStoreMan(bool flag)
		{
			if (flag && !this.ColumnList.Contains("StoreMan"))
			{
				this.ColumnList.Add("StoreMan");
			}
			return this;
		}

		[DataMapping(ColumnName = "Status", DbType = DbType.String, Length = 20, CanNull = true, DefaultValue = null, PrimaryKey = false, AutoIncrement = false, IsMap = true)]
		public string Status { get; set; }

		public PartEntity IncludeStatus(bool flag)
		{
			if (flag && !this.ColumnList.Contains("Status"))
			{
				this.ColumnList.Add("Status");
			}
			return this;
		}

		[DataMapping(ColumnName = "CreatedBy", DbType = DbType.String, Length = 40, CanNull = true, DefaultValue = null, PrimaryKey = false, AutoIncrement = false, IsMap = true)]
		public string CreatedBy { get; set; }

		public PartEntity IncludeCreatedBy(bool flag)
		{
			if (flag && !this.ColumnList.Contains("CreatedBy"))
			{
				this.ColumnList.Add("CreatedBy");
			}
			return this;
		}

		[DataMapping(ColumnName = "CreationDate", DbType = DbType.DateTime, Length = 8, CanNull = true, DefaultValue = null, PrimaryKey = false, AutoIncrement = false, IsMap = true)]
		public DateTime CreationDate { get; set; }

		public PartEntity IncludeCreationDate(bool flag)
		{
			if (flag && !this.ColumnList.Contains("CreationDate"))
			{
				this.ColumnList.Add("CreationDate");
			}
			return this;
		}

		[DataMapping(ColumnName = "UpdatedBy", DbType = DbType.String, Length = 40, CanNull = true, DefaultValue = null, PrimaryKey = false, AutoIncrement = false, IsMap = true)]
		public string UpdatedBy { get; set; }

		public PartEntity IncludeUpdatedBy(bool flag)
		{
			if (flag && !this.ColumnList.Contains("UpdatedBy"))
			{
				this.ColumnList.Add("UpdatedBy");
			}
			return this;
		}

		[DataMapping(ColumnName = "UpdateDate", DbType = DbType.DateTime, Length = 8, CanNull = true, DefaultValue = null, PrimaryKey = false, AutoIncrement = false, IsMap = true)]
		public DateTime UpdateDate { get; set; }

		public PartEntity IncludeUpdateDate(bool flag)
		{
			if (flag && !this.ColumnList.Contains("UpdateDate"))
			{
				this.ColumnList.Add("UpdateDate");
			}
			return this;
		}

	}


	public partial class PartEntity
	{
	}
}

