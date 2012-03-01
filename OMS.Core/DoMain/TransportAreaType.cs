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
 /// TransportAreaType
 /// ����������
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
 [Table( "TransportArea" )]
 [Serializable]
 public class TransportAreaType: ObjectBase<TransportAreaType> 
 {

      ///<summary>
      /// Id
      ///</summary>
  //public int Id { get; set; }

      ///<summary>
      /// ��������
      ///</summary>
  public String AreaName { get; set; }

      ///<summary>
      /// ������ʽ
      ///</summary>
  public String TransportCode { get; set; }

      ///<summary>
      /// ��������
      ///</summary>
  public String TransportName { get; set; }
  }
}
