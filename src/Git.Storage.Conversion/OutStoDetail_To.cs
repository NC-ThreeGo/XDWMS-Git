/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: 代码工具自动生成
 * Create Date: 2014/05/09 22:46:44
 * Blog: http://www.cnblogs.com/qingyuan/ 
 * Copyright: 太数智能科技（上海）有限公司 
 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2014/05/09 22:46:44
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Git.Storage.RoseEntity;
using Git.Storage.Entity.OutStorage;

namespace Git.Storage.Conversion
{
	public partial class OutStoDetail_To
	{
		public OutStoDetail_To()
		{
		}

		public static OutStoDetailEntity To(OutStoDetail_CE item)
		{
			OutStoDetailEntity target = new OutStoDetailEntity();
			target.ID=item.ID;
			target.SnNum=item.SnNum;
			target.OrderNum=item.OrderNum;
			target.ProductName=item.ProductName;
			target.BarCode=item.BarCode;
			target.ProductNum=item.ProductNum;
			target.BatchNum=item.BatchNum;
			target.LocalNum=item.LocalNum;
			target.StorageNum=item.StorageNum;
			target.Num=item.Num;
			target.IsPick=item.IsPick;
			target.RealNum=item.RealNum;
			target.OutPrice=item.OutPrice;
			target.Amount=item.Amount;
			target.CreateTime=item.CreateTime;
			return target;
		}

		public static OutStoDetail_CE ToCE(OutStoDetailEntity item)
		{
			OutStoDetail_CE target = new OutStoDetail_CE();
			target.ID=item.ID;
			target.SnNum=item.SnNum;
			target.OrderNum=item.OrderNum;
			target.ProductName=item.ProductName;
			target.BarCode=item.BarCode;
			target.ProductNum=item.ProductNum;
			target.BatchNum=item.BatchNum;
			target.LocalNum=item.LocalNum;
			target.StorageNum=item.StorageNum;
			target.Num=item.Num;
			target.IsPick=item.IsPick;
			target.RealNum=item.RealNum;
			target.OutPrice=item.OutPrice;
			target.Amount=item.Amount;
			target.CreateTime=item.CreateTime;
			return target;
		}
	}
}
