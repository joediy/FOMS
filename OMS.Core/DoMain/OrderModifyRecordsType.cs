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
 /// OrderModifyRecordsType
 /// �����޸ļ�¼
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
 [Table( "OrderModifyRecords" )]
 [Serializable]
 public class OrderModifyRecordsType: ObjectBase<OrderModifyRecordsType> 
 {

      ///<summary>
      /// Id
      ///</summary>
  //public int Id { get; set; }

      ///<summary>
      /// ��������
      ///</summary>
  public int OrderID { get; set; }

      ///<summary>
      /// �������
      ///</summary>
  public String OrderNo { get; set; }

      ///<summary>
      /// �޸�ʱ��
      ///</summary>
  public DateTime OrderModifyDate { get; set; }

      ///<summary>
      /// �޸��ֶ�
      ///</summary>
  public String OrderModifyColumn { get; set; }

      ///<summary>
      /// ԭ����ֵ
      ///</summary>
  public String OrderModifyContent { get; set; }

      ///<summary>
      /// �޸ĺ��ֵ
      ///</summary>
  public String OrderModifyContent2 { get; set; }
  }
}
