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
 /// StockInType
 /// ����
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
 [Table( "StockIn" )]
 [Serializable]
 public class StockInType: ObjectBase<StockInType> 
 {

      ///<summary>
      /// Id
      ///</summary>
  //public int Id { get; set; }

      ///<summary>
      /// ���ʱ��
      ///</summary>
  public DateTime CreateOn { get; set; }

      ///<summary>
      /// Sku
      ///</summary>
  public String SKU { get; set; }

      ///<summary>
      /// ����
      ///</summary>
  public int ItemNum { get; set; }

      ///<summary>
      /// �������
      ///</summary>
  public String InType { get; set; }

      ///<summary>
      /// ���״̬
      ///</summary>
  public String InStatus { get; set; }

      ///<summary>
      /// ������Ϣ
      ///</summary>
  public String ErrorString { get; set; }
  }
}
