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
 /// EbayItemType
 /// Ebay��Ʒ��Ϣ
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
 [Table( "EbayItem" )]
 [Serializable]
 public class EbayItemType: ObjectBase<EbayItemType> 
 {

      ///<summary>
      /// Id
      ///</summary>
  //public int Id { get; set; }

      ///<summary>
      /// ��ƷID
      ///</summary>
  public String ItemId { get; set; }

      ///<summary>
      /// ����
      ///</summary>
  public String ItemTitle { get; set; }

      ///<summary>
      /// ����
      ///</summary>
  public String CurrencyID { get; set; }

      ///<summary>
      /// �۸�
      ///</summary>
  public String ItemPrice { get; set; }

      ///<summary>
      /// ͼƬ��ַ
      ///</summary>
  public String PictureURL { get; set; }

      ///<summary>
      /// �ܹ�����
      ///</summary>
  public int BeginNum { get; set; }

      ///<summary>
      /// ���ڿ��
      ///</summary>
  public int NowNum { get; set; }

      ///<summary>
      /// ��Ʒ����
      ///</summary>
  public String ItemURL { get; set; }

      ///<summary>
      /// ����ʱ��
      ///</summary>
  public DateTime StartTime { get; set; }

      ///<summary>
      /// ����ʱ��
      ///</summary>
  public DateTime CreateOn { get; set; }

      ///<summary>
      /// �˻�
      ///</summary>
  public String AccountFrom { get; set; }
  }
}
