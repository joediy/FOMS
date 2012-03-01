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
    /// CurrencyType
    /// ���ʱ�
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
    [Table("CurrencyTable")]
    [Serializable]
    public class CurrencyType : ObjectBase<CurrencyType>
    {

        ///<summary>
        /// Id
        ///</summary>
        //public int Id { get; set; }

        ///<summary>
        /// CurrencyName
        ///</summary>
        public String CurrencyName { get; set; }

        ///<summary>
        /// CurrencyCode
        ///</summary>
        public String CurrencyCode { get; set; }

        ///<summary>
        /// CurrencyValue
        ///</summary>
        public Double CurrencyValue { get; set; }

        ///<summary>
        /// CreateOn
        ///</summary>
        public DateTime CreateOn { get; set; }
    }
}