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
 /// GoodsType
 /// ��Ʒ��
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
 [Table( "Goods" )]
 [Serializable]
 public class GoodsType: ObjectBase<GoodsType> 
 {

      ///<summary>
      /// Id
      ///</summary>
  //public int Id { get; set; }

      ///<summary>
      /// ��Ʒ���
      ///</summary>
  public String ItemSku { get; set; }

      ///<summary>
      /// ��ƷӢ������
      ///</summary>
  public String ItemEName { get; set; }

      ///<summary>
      /// ��Ʒ��������
      ///</summary>
  public String ItemName { get; set; }

      ///<summary>
      /// ��Ʒ����
      ///</summary>
  public String ItemType { get; set; }

      ///<summary>
      /// ��Ʒ�ͺ�
      ///</summary>
  public String ItemModel { get; set; }

      ///<summary>
      /// ��Ʒ��ɫ
      ///</summary>
  public String ItemColor { get; set; }

      ///<summary>
      /// ��Ʒ�ɱ���
      ///</summary>
  public Double ItemPrice { get; set; }

      ///<summary>
      /// ��Ʒ����
      ///</summary>
  public Double ItemWeight { get; set; }

      ///<summary>
      /// ��
      ///</summary>
  public Double ItemLong { get; set; }

      ///<summary>
      /// ��
      ///</summary>
  public Double ItemWide { get; set; }

      ///<summary>
      /// ��
      ///</summary>
  public Double ItemHigh { get; set; }

      ///<summary>
      /// ��Ʒ��������
      ///</summary>
  public int ItemNum { get; set; }

      ///<summary>
      /// Ԥ������
      ///</summary>
  public int ItemLower { get; set; }

      ///<summary>
      /// ���ڲֿ����
      ///</summary>
  public String WarehouseCode { get; set; }

      ///<summary>
      /// ���ڲֿ�����
      ///</summary>
  public String WarehouseName { get; set; }

      ///<summary>
      /// Ԥ������
      ///</summary>
  public int ItemUpper { get; set; }

      ///<summary>
      /// Description
      ///</summary>
  public String Description { get; set; }

      ///<summary>
      /// DeletionStateCode
      ///</summary>
  public int DeletionStateCode { get; set; }

      ///<summary>
      /// Enabled
      ///</summary>
  public int Enabled { get; set; }

      ///<summary>
      /// SortCode
      ///</summary>
  public int SortCode { get; set; }

      ///<summary>
      /// CreateOn
      ///</summary>
  public DateTime CreateOn { get; set; }

      ///<summary>
      /// CreateUserId
      ///</summary>
  public String CreateUserId { get; set; }

      ///<summary>
      /// CreateBy
      ///</summary>
  public String CreateBy { get; set; }

      ///<summary>
      /// ModifiedOn
      ///</summary>
  public DateTime ModifiedOn { get; set; }

      ///<summary>
      /// ModifiedUserId
      ///</summary>
  public String ModifiedUserId { get; set; }

      ///<summary>
      /// ModifiedBy
      ///</summary>
  public String ModifiedBy { get; set; }
  }
}
