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
 /// TransportConditionType
 /// ��������������
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
 [Table( "TransportCondition" )]
 [Serializable]
 public class TransportConditionType: ObjectBase<TransportConditionType> 
 {

      ///<summary>
      /// Id
      ///</summary>
  //public int Id { get; set; }

      ///<summary>
      /// ��������
      ///</summary>
  public String Title { get; set; }

      ///<summary>
      /// ����ֵ
      ///</summary>
  public String TransportValue { get; set; }

      ///<summary>
      /// ����
      ///</summary>
  public String TransportArgs { get; set; }

      ///<summary>
      /// �жϷ�ʽ
      ///</summary>
  public String TransportCondition { get; set; }

      ///<summary>
      /// ���ȼ�
      ///</summary>
  public int Priority { get; set; }

      ///<summary>
      /// ������ʽ
      ///</summary>
  public String TransportCode { get; set; }

      ///<summary>
      /// ƽ̨����
      ///</summary>
  public String PlatformCode { get; set; }

      ///<summary>
      /// ��ע
      ///</summary>
  public String Remark { get; set; }
  }
}
