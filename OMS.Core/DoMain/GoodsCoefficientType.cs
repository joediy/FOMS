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
    /// GoodsCoefficientType
    /// ��Ʒ��Ӧϵ����
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
    [Table("GoodsCoefficient")]
    [Serializable]
    public class GoodsCoefficientType : ObjectBase<GoodsCoefficientType>
    {

        ///<summary>
        /// Id
        ///</summary>
        //public int Id { get; set; }

        ///<summary>
        /// ƽ̨sku
        ///</summary>
        public String SaleSku { get; set; }

        ///<summary>
        /// �ڲ���ƷSku
        ///</summary>
        public String ItemSku { get; set; }

        ///<summary>
        /// ����
        ///</summary>
        public String Description { get; set; }

        ///<summary>
        /// ��Ʒ����
        ///</summary>
        public int GoodsNum { get; set; }
    }
}
