//--------------------------------------------------------------------
// All Rights Reserved , Copyright (C) 2012 , FeiDu TECH, Ltd.
//--------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using wojilu;
using wojilu.ORM;

namespace OMS.Core.DoMain
{

 /// <summary>
 /// PackageGoodsType
 /// ������Ʒ��
 ///
 /// �޸ļ�¼
 ///
 ///		2012-02-02 �汾��1.0 XD ����������
 ///
 /// �汾��1.0
 ///
 /// <author>
 ///		<name>XD</name>
 ///		<date>2012-02-02</date>
 /// </author>
 /// </summary>
 [Table( "PackageGoods" )]
 [Serializable]
 public class PackageGoodsType: ObjectBase<PackageGoodsType> 
 {

      ///<summary>
      /// Id
      ///</summary>
  //public int Id { get; set; }

      ///<summary>
      /// ������
      ///</summary>
  public String PackageNo { get; set; }

      ///<summary>
      /// ��ƷSku
      ///</summary>
  public String Sku { get; set; }

      ///<summary>
      /// ��Ʒ����
      ///</summary>
  public int ItemQty { get; set; }
  }
}
