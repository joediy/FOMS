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
 /// TransportAreaCountryType
 /// �������ұ�
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
 [Table( "TransportAreaCountry" )]
 [Serializable]
 public class TransportAreaCountryType: ObjectBase<TransportAreaCountryType> 
 {

      ///<summary>
      /// Id
      ///</summary>
  //public int Id { get; set; }

      ///<summary>
      /// �������
      ///</summary>
  public String AreaCode { get; set; }

      ///<summary>
      /// ���Ҵ���
      ///</summary>
  public String CountryCode { get; set; }
  }
}
