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
    /// OrderType
    /// ������
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
    [Table("Orders")]
    [Serializable]
    public class OrderType : ObjectBase<OrderType>
    {

        ///<summary>
        /// ������ʶ
        ///</summary>
        //public int Id { get; set; }

        ///<summary>
        /// �����ţ���˾�ڲ���
        ///</summary>
        public String OrderNo { get; set; }

        ///<summary>
        /// �����ţ�����ƽ̨��
        ///</summary>
        public String OrderExNo { get; set; }

        ///<summary>
        /// ���н��׺�
        ///</summary>
        public String TxnId { get; set; }

        ///<summary>
        /// ��������
        ///</summary>
        public string NowOrderType { get; set; }

        ///<summary>
        /// ����״̬
        ///</summary>
        public string OrderStatus { get; set; }

        ///<summary>
        /// ����״̬
        ///</summary>
        public string ShippedStatus { get; set; }

        ///<summary>
        /// �Ƿ񸶿�
        ///</summary>
        public string PayStatus { get; set; }

        ///<summary>
        /// �Ƿ��ӡ
        ///</summary>
        public int IsPrint { get; set; }

        ///<summary>
        /// ��ӡ����
        ///</summary>
        public int PrintNum { get; set; }

        ///<summary>
        /// �������
        ///</summary>
        public Double OrderAmount { get; set; }

        ///<summary>
        /// ����
        ///</summary>
        public String OrderCurrencyCode { get; set; }

        ///<summary>
        /// ƽ̨����
        ///</summary>
        public Double OrderSaleTax { get; set; }

        ///<summary>
        /// �������
        ///</summary>
        public String PayCurrencyCode { get; set; }

        ///<summary>
        /// ���׷�
        ///</summary>
        public Double OrderPayTax { get; set; }

        ///<summary>
        /// ���䷽ʽ
        ///</summary>
        public String TransportMode { get; set; }

        ///<summary>
        /// ���Id
        ///</summary>
        public String BuyerId { get; set; }

        ///<summary>
        /// ��Ҵ���
        ///</summary>
        public String BuyerCode { get; set; }

        ///<summary>
        /// ���Id
        ///</summary>
        public String AddressId { get; set; }

        ///<summary>
        /// ����ʱ��
        ///</summary>
        public DateTime PayTime { get; set; }

        ///<summary>
        /// ���ʽ
        ///</summary>
        public String Payment { get; set; }

        ///<summary>
        /// �����˺�
        ///</summary>
        public String PayEmail { get; set; }

        ///<summary>
        /// ƽ̨
        ///</summary>
        public String OrderForm { get; set; }

        ///<summary>
        /// �˺�
        ///</summary>
        public String UserNameForm { get; set; }

        ///<summary>
        /// ������ע
        ///</summary>
        [Column(Length = 800)]
        public String OrderNote { get; set; }

        ///<summary>
        /// ͬ��ʱ��
        ///</summary>
        public DateTime AddTime { get; set; }

        /// <summary>
        /// �ϲ��������ϲ�������д���ϲ������ļ��ϣ������ϲ�������д�ϲ��ɶ�����id��
        /// </summary>
        public string Mergerorders { get; set; }



        ///<summary>
        /// �ǲ��Ǳ��ϲ�����
        ///</summary>
        public int Enabled { get; set; }

        ///<summary>
        /// ɾ������
        ///</summary>
        public int DeletionStateCode { get; set; }

        ///<summary>
        /// ������
        ///</summary>
        public int SortCode { get; set; }

        ///<summary>
        /// ����
        ///</summary>
        public String Description { get; set; }

        ///<summary>
        /// ���ʱ��
        ///</summary>
        public DateTime CreateOn { get; set; }

        ///<summary>
        /// ����˴���
        ///</summary>
        public String CreateUserId { get; set; }

        ///<summary>
        /// �����
        ///</summary>
        public String CreateBy { get; set; }

        ///<summary>
        /// �޸�ʱ��
        ///</summary>
        public DateTime ModifiedOn { get; set; }

        ///<summary>
        /// �޸��˴���
        ///</summary>
        public String ModifiedUserId { get; set; }

        ///<summary>
        /// �޸���
        ///</summary>
        public String ModifiedBy { get; set; }


        /// <summary>
        /// �����еĲ�Ʒ
        /// </summary>
        private List<OrderGoodsType> orderGoods;
        [NotSave]
        public List<OrderGoodsType> OrderGoods
        {
            get
            {
                if (orderGoods == null)
                    orderGoods = OrderGoodsType.find("OrderNo=:t1").set("t1", Id).list();
                if (orderGoods == null)
                    orderGoods = new List<OrderGoodsType>();
                return orderGoods;
            }
            set { orderGoods = value; }
        }
    }
}
