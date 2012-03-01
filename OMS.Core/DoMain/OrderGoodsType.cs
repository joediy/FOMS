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
    /// OrderGoodsType
    /// ������Ʒ����
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
    [Table("OrderGoods")]
    [Serializable]
    public class OrderGoodsType : ObjectBase<OrderGoodsType>
    {

        ///<summary>
        /// ������ʶ
        ///</summary>
        //public int Id { get; set; }

        ///<summary>
        /// �������
        ///</summary>
        public String OrderNo { get; set; }

        ///<summary>
        /// ��Ʒ����ƽ̨Code
        ///</summary>
        public String Sku { get; set; }

        ///<summary>
        /// ��Ʒ����
        ///</summary>
        public String ItemName { get; set; }

        ///<summary>
        /// ��Ʒ�ڲ����
        ///</summary>
        public String ItemNo { get; set; }

        ///<summary>
        /// ���ۼ۸�
        ///</summary>
        public Double ItemPrice { get; set; }

        ///<summary>
        /// ��ƷͼƬ
        ///</summary>
        public String ItemImg { get; set; }

        ///<summary>
        /// ��Ʒ����
        ///</summary>
        public int ItemNum { get; set; }

        ///<summary>
        /// ��Ʒ����
        ///</summary>
        public String ItemAttr { get; set; }

        ///<summary>
        /// ��Ʒ����
        ///</summary>
        public String ItemDesc { get; set; }

        ///<summary>
        /// ��Ʒȱ��
        ///</summary>
        public int Enabled { get; set; }
    }
}
