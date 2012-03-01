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
 /// TransportFreightType
 /// �����˷ѱ�
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
 [Table( "TransportFreight" )]
 [Serializable]
 public class TransportFreightType: ObjectBase<TransportFreightType> 
 {

      ///<summary>
      /// Id
      ///</summary>
  //public int Id { get; set; }

      ///<summary>
      /// ��������
      ///</summary>
  public String AreaCode { get; set; }

      ///<summary>
      /// ��������
      ///</summary>
  public String TransportCode { get; set; }

      ///<summary>
      /// ����
      ///</summary>
  public int BeginWeight { get; set; }

      ///<summary>
      /// ��������
      ///</summary>
  public int EndWeight { get; set; }

      ///<summary>
      /// ����
      ///</summary>
  public int IncrementWeight { get; set; }

      ///<summary>
      /// ���ط���
      ///</summary>
  public Double FrisFreight { get; set; }

      ///<summary>
      /// ��������
      ///</summary>
  public Double IncrementFreight { get; set; }

      ///<summary>
      /// �����
      ///</summary>
  public Double ProcessingFee { get; set; }

      ///<summary>
      /// �ۿ�
      ///</summary>
  public Double Discount { get; set; }

      ///<summary>
      /// ������Ƿ����
      ///</summary>
  public int IsDiscountALL { get; set; }

      ///<summary>
      /// ��ע
      ///</summary>
  public String Remark { get; set; }
  }
}
