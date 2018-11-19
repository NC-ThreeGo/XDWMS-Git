/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: 代码工具自动生成
 * Create Date: 2014/05/09 22:48:58
 * Blog: http://www.cnblogs.com/qingyuan/ 
 * Copyright: 太数智能科技（上海）有限公司 
 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2014/05/09 22:48:58
*********************************************************************************/

using System;
using System.Text;
using System.Data;

namespace Git.Storage.RoseEntity
{
	[Serializable]
	public partial class Customer_CE
	{
		public Customer_CE()
		{
		}

		private Int32 _ID;
		public Int32 ID
		{
			set { this._ID = value; }
			get { return this._ID;}
		}

		private string _CusNum;
		public string CusNum
		{
			set { this._CusNum = value; }
			get { return this._CusNum;}
		}

		private string _CusName;
		public string CusName
		{
			set { this._CusName = value; }
			get { return this._CusName;}
		}

		private string _Phone;
		public string Phone
		{
			set { this._Phone = value; }
			get { return this._Phone;}
		}

		private string _Email;
		public string Email
		{
			set { this._Email = value; }
			get { return this._Email;}
		}

		private string _Fax;
		public string Fax
		{
			set { this._Fax = value; }
			get { return this._Fax;}
		}

		private string _Address;
		public string Address
		{
			set { this._Address = value; }
			get { return this._Address;}
		}

		private Int32 _CusType;
		public Int32 CusType
		{
			set { this._CusType = value; }
			get { return this._CusType;}
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

		private string _Remark;
		public string Remark
		{
			set { this._Remark = value; }
			get { return this._Remark;}
		}

	}
}
