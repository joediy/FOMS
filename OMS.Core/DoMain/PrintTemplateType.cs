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
    /// PrintTemplateType
    /// ��ӡģ���
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
    [Table("PrintTemplate")]
    [Serializable]
    public class PrintTemplateType : ObjectBase<PrintTemplateType>
    {



        ///<summary>
        /// ����
        ///</summary>

        public String Name { get; set; }

        ///<summary>
        /// ģ������
        ///</summary>
        [LongText]
        public String Content { get; set; }

        ///<summary>
        /// ��ע
        ///</summary>
        public String Remark { get; set; }
    }
}
