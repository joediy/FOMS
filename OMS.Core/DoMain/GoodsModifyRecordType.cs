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
 /// GoodsModifyRecordType
 /// ��Ʒ�޸ļ�¼
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
 [Table( "GoodsModifyRecord" )]
 [Serializable]
 public class GoodsModifyRecordType: ObjectBase<GoodsModifyRecordType> 
 {

      ///<summary>
      /// ������ʶ
      ///</summary>
  //public int Id { get; set; }

      ///<summary>
      /// �޸���
      ///</summary>
  public String ModifyUserCode { get; set; }

      ///<summary>
      /// �޸�ʱ��
      ///</summary>
  public DateTime ModifyDate { get; set; }

      ///<summary>
      /// �޸��ֶ�
      ///</summary>
  public String ModifyField { get; set; }

      ///<summary>
      /// �޸�ǰ��ֵ
      ///</summary>
  public String ModifyBeforeValue { get; set; }

      ///<summary>
      /// �޸ĺ��ֵ
      ///</summary>
  public String ModifyAfterValue { get; set; }
  }
}
