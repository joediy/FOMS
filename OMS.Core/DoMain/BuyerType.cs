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
 /// BuyerType
 /// ��ұ�
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
 [Table( "Buyers" )]
 [Serializable]
 public class BuyerType: ObjectBase<BuyerType> 
 {

      ///<summary>
      /// ������ʶ
      ///</summary>
  //public int Id { get; set; }

      ///<summary>
      /// ��Ҵ���
      ///</summary>
  public String BuyerCode { get; set; }

      ///<summary>
      /// ƽ̨
      ///</summary>
  public String PlatformCode { get; set; }

      ///<summary>
      /// ��Ҽ���
      ///</summary>
  public int BuyerLevel { get; set; }

      ///<summary>
      /// ��ҹ������
      ///</summary>
  public int BuyCount { get; set; }
  }
}
