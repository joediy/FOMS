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
 /// EmailTemplateType
 /// �ʼ�ģ���
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
 [Table( "EmailTemplate" )]
 [Serializable]
 public class EmailTemplateType: ObjectBase<EmailTemplateType> 
 {

      ///<summary>
      /// ������ʶ
      ///</summary>
  //public int Id { get; set; }

      ///<summary>
      /// ����
      ///</summary>
  public String Title { get; set; }

      ///<summary>
      /// ����
      ///</summary>
  public String Subject { get; set; }

      ///<summary>
      /// ����
      ///</summary>
  public String Content { get; set; }

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
