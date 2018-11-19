/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: 代码工具自动生成
 * Create Date: 2014/05/09 22:47:49
 * Blog: http://www.cnblogs.com/qingyuan/ 
 * Copyright: 太数智能科技（上海）有限公司 
 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2014/05/09 22:47:49
*********************************************************************************/

using System;
using System.Text;
using System.Data;

namespace Git.Storage.RoseEntity
{
	[Serializable]
	public partial class BadReport_CE
	{
		public BadReport_CE()
		{
		}

		private Int32 _ID;
		public Int32 ID
		{
			set { this._ID = value; }
			get { return this._ID;}
		}

		private string _OrderNum;
		public string OrderNum
		{
			set { this._OrderNum = value; }
			get { return this._OrderNum;}
		}

		private Int32 _BadType;
		public Int32 BadType
		{
			set { this._BadType = value; }
			get { return this._BadType;}
		}

		private Int32 _ProductType;
		public Int32 ProductType
		{
			set { this._ProductType = value; }
			get { return this._ProductType;}
		}

		private string _ContractOrder;
		public string ContractOrder
		{
			set { this._ContractOrder = value; }
			get { return this._ContractOrder;}
		}

		private Int32 _Status;
		public Int32 Status
		{
			set { this._Status = value; }
			get { return this._Status;}
		}

        private double _Num;
        public double Num
		{
			set { this._Num = value; }
			get { return this._Num;}
		}

        private double _Amount;
        public double Amount
		{
			set { this._Amount = value; }
			get { return this._Amount;}
		}

		private double _Weight;
		public double Weight
		{
			set { this._Weight = value; }
			get { return this._Weight;}
		}

		private Int32 _IsDelete;
		public Int32 IsDelete
		{
			set { this._IsDelete = value; }
			get { return this._IsDelete;}
		}

		private DateTime _CreateTime;
		public DateTime CreateTime
		{
			set { this._CreateTime = value; }
			get { return this._CreateTime;}
		}

		private string _CreateUser;
		public string CreateUser
		{
			set { this._CreateUser = value; }
			get { return this._CreateUser;}
		}

		private string _AuditUser;
		public string AuditUser
		{
			set { this._AuditUser = value; }
			get { return this._AuditUser;}
		}

		private DateTime _AuditeTime;
		public DateTime AuditeTime
		{
			set { this._AuditeTime = value; }
			get { return this._AuditeTime;}
		}

		private string _PrintUser;
		public string PrintUser
		{
			set { this._PrintUser = value; }
			get { return this._PrintUser;}
		}

		private DateTime _PrintTime;
		public DateTime PrintTime
		{
			set { this._PrintTime = value; }
			get { return this._PrintTime;}
		}

		private string _Reason;
		public string Reason
		{
			set { this._Reason = value; }
			get { return this._Reason;}
		}

		private Int32 _OperateType;
		public Int32 OperateType
		{
			set { this._OperateType = value; }
			get { return this._OperateType;}
		}

		private string _EquipmentNum;
		public string EquipmentNum
		{
			set { this._EquipmentNum = value; }
			get { return this._EquipmentNum;}
		}

		private string _EquipmentCode;
		public string EquipmentCode
		{
			set { this._EquipmentCode = value; }
			get { return this._EquipmentCode;}
		}

		private string _Remark;
		public string Remark
		{
			set { this._Remark = value; }
			get { return this._Remark;}
		}

	}
}
