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
 /// PaypalAccountType
 /// Paypal�˻���
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
 [Table( "PaypalAccount" )]
 [Serializable]
 public class PaypalAccountType: ObjectBase<PaypalAccountType> 
 {

      ///<summary>
      /// Id
      ///</summary>
  //public int Id { get; set; }

      ///<summary>
      /// �û���
      ///</summary>
  public String UserName { get; set; }

      ///<summary>
      /// API��
      ///</summary>
  public String APIKEY { get; set; }

      ///<summary>
      /// API����
      ///</summary>
  public String APIPWD { get; set; }

      ///<summary>
      /// API Token
      ///</summary>
  public String ApiToken { get; set; }

      ///<summary>
      /// ����
      ///</summary>
  public String Description { get; set; }

      ///<summary>
      /// �˻�״̬
      ///</summary>
  public String AccountStatus { get; set; }
  }
}
