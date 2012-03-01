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
 /// CompanyType
 /// ��˾��
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
 [Table( "Company" )]
 [Serializable]
 public class CompanyType: ObjectBase<CompanyType> 
 {

      ///<summary>
      /// Id
      ///</summary>
  //public int Id { get; set; }

      ///<summary>
      /// ��˾���루�û���¼�ã�
      ///</summary>
  public String Code { get; set; }

      ///<summary>
      /// ���
      ///</summary>
  public String ShortName { get; set; }

      ///<summary>
      /// ȫ��
      ///</summary>
  public String FullName { get; set; }

      ///<summary>
      /// ����
      ///</summary>
  public String Category { get; set; }

      ///<summary>
      /// ��˾�绰
      ///</summary>
  public String InnerPhone { get; set; }

      ///<summary>
      /// ����
      ///</summary>
  public String Fax { get; set; }

      ///<summary>
      /// �ʱ�
      ///</summary>
  public String Postalcode { get; set; }

      ///<summary>
      /// ��ַ
      ///</summary>
  public String Address { get; set; }

      ///<summary>
      /// ��ַ
      ///</summary>
  public String Web { get; set; }

      ///<summary>
      /// ������
      ///</summary>
  public String Manager { get; set; }

      ///<summary>
      /// ��������
      ///</summary>
  public String AssistantManager { get; set; }

      ///<summary>
      /// ��ֵʱ��
      ///</summary>
  public DateTime RechargeDate { get; set; }

      ///<summary>
      /// ��ֵ����
      ///</summary>
  public int RechargeDay { get; set; }

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
      /// Description
      ///</summary>
  public String Description { get; set; }

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
