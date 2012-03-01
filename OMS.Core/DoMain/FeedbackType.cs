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
 /// FeedbackType
 /// ����
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
 [Table( "Feedback" )]
 [Serializable]
 public class FeedbackType: ObjectBase<FeedbackType> 
 {

      ///<summary>
      /// ������ʶ
      ///</summary>
  //public int Id { get; set; }

      ///<summary>
      /// ��ƷId
      ///</summary>
  public String ItemId { get; set; }

      ///<summary>
      /// ��������
      ///</summary>
  public String NowFeedbackType { get; set; }

      ///<summary>
      /// ��������
      ///</summary>
  public String FeedbackContent { get; set; }

      ///<summary>
      /// ��Ҵ���
      ///</summary>
  public String BuyerCode { get; set; }

      ///<summary>
      /// ��Һ�����
      ///</summary>
  public int PositiveFeedbackCount { get; set; }

      ///<summary>
      /// ��Ҳ�����
      ///</summary>
  public int NegativeFeedbackCount { get; set; }
  }
}
