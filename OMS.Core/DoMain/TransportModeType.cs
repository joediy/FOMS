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
 /// TransportModeType
 /// ���䷽ʽ��
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
 [Table( "TransportMode" )]
 [Serializable]
 public class TransportModeType: ObjectBase<TransportModeType> 
 {

      ///<summary>
      /// Id
      ///</summary>
  //public int Id { get; set; }

      ///<summary>
      /// ���䷽ʽ
      ///</summary>
  public String TransportName { get; set; }

      ///<summary>
      /// ��������
      ///</summary>
  public String TransportType { get; set; }

      ///<summary>
      /// �Ƿ���׷����
      ///</summary>
  public int HasTrackCode { get; set; }

      ///<summary>
      /// ��ע
      ///</summary>
  public String Remark { get; set; }
  }
}
