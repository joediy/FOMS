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
 /// GoodsCategoryType
 /// ��Ʒ����
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
 [Table( "GoodsCategory" )]
 [Serializable]
 public class GoodsCategoryType: ObjectBase<GoodsCategoryType> 
 {

      ///<summary>
      /// Id
      ///</summary>
  //public int Id { get; set; }

      ///<summary>
      /// ��������
      ///</summary>
  public String CategoryName { get; set; }

      ///<summary>
      /// ����Ӣ����
      ///</summary>
  public String CategoryEName { get; set; }

      ///<summary>
      /// ����
      ///</summary>
  public String Description { get; set; }
  }
}
