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
 /// EmailFieldType
 /// �ʼ��ֶα�
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
 [Table( "EmailField" )]
 [Serializable]
 public class EmailFieldType: ObjectBase<EmailFieldType> 
 {

      ///<summary>
      /// ������ʶ
      ///</summary>
  //public int Id { get; set; }

      ///<summary>
      /// �ֶδ���
      ///</summary>
  public String FieldCode { get; set; }

      ///<summary>
      /// �ֶ�����
      ///</summary>
  public String FieldName { get; set; }

      ///<summary>
      /// �ֶ���
      ///</summary>
  public String FieldByClass { get; set; }
  }
}
