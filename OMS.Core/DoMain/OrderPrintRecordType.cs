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
    /// OrderPrintRecordType
    /// ������ӡ��¼��
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
    [Table("OrderPrintRecord")]
    [Serializable]
    public class OrderPrintRecordType : ObjectBase<OrderPrintRecordType>
    {

        ///<summary>
        /// ��ӡ��ʶ
        ///</summary>
        //public int Id { get; set; }
        ///<summary>
        /// ��������
        ///</summary>
        public string Title { get; set; }

        ///<summary>
        /// ��������
        ///</summary>
        public int OrderNum { get; set; }

        ///<summary>
        /// ��������
        ///</summary>
        public string OrderCondition { get; set; }

        ///<summary>
        /// ����Id
        ///</summary>
        [Column(Length = 8000)]
        public string OrderIds { get; set; }

        ///<summary>
        /// ��ӡʱ��
        ///</summary>
        public DateTime CreateOn { get; set; }
    }
}
