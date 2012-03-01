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
 /// SerialNumberType
 /// ���кű�
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
 [Table( "SerialNumber" )]
 [Serializable]
 public class SerialNumberType: ObjectBase<SerialNumberType> 
 {

      ///<summary>
      /// Id
      ///</summary>
  //public int Id { get; set; }

      ///<summary>
      /// ����
      ///</summary>
  public String FullName { get; set; }

      ///<summary>
      /// ���к�ǰ׺
      ///</summary>
  public String Prefix { get; set; }

      ///<summary>
      /// ���кŷָ���
      ///</summary>
  public String Separator { get; set; }

      ///<summary>
      /// ��������
      ///</summary>
  public int Sequence { get; set; }

      ///<summary>
      /// ��������
      ///</summary>
  public int Reduction { get; set; }

      ///<summary>
      /// ����
      ///</summary>
  public int Step { get; set; }

      ///<summary>
      /// ����
      ///</summary>
  public String Description { get; set; }
  }
}
