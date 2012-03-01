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
    /// DisputeInfo
    /// ���ױ�
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
    [Table("Dispute")]
    [Serializable]
    public class DisputeType : ObjectBase<DisputeType>
    {

        ///<summary>
        /// Id
        ///</summary>
        //public int Id { get; set; }

        ///<summary>
        /// ƽ̨
        ///</summary>
        public String PlatformName { get; set; }

        ///<summary>
        /// �˻�
        ///</summary>
        public String SaleAccountName { get; set; }

        ///<summary>
        /// �������
        ///</summary>
        public String OrderNo { get; set; }

        ///<summary>
        /// ��������
        ///</summary>
        public String OrderId { get; set; }

        ///<summary>
        /// ��������
        ///</summary>
        public DateTime SendOrderDate { get; set; }

        ///<summary>
        /// ��Ʒ����
        ///</summary>
        public String ItemId { get; set; }

        ///<summary>
        /// ��Ʒ���
        ///</summary>
        public String ItemNo { get; set; }

        ///<summary>
        /// ������
        ///</summary>
        public String TrackCode { get; set; }

        ///<summary>
        /// ���䷽ʽ
        ///</summary>
        public String TransportMode { get; set; }

        ///<summary>
        /// ��������
        ///</summary>
        public String DisputeCategory { get; set; }

        ///<summary>
        /// ����С����
        ///</summary>
        public String DisputeTypeCode { get; set; }

        ///<summary>
        /// ����
        ///</summary>
        public String Remark { get; set; }

        ///<summary>
        /// �����ʽ
        ///</summary>
        public String DisputeSolutionType { get; set; }

        ///<summary>
        /// �˿���
        ///</summary>
        public Double RefundAmount { get; set; }

        ///<summary>
        /// ����ʱ��
        ///</summary>
        public DateTime CreateOn { get; set; }

        ///<summary>
        /// ����״̬
        ///</summary>
        public String DisputeStatus { get; set; }

        ///<summary>
        /// ���ʱ��
        ///</summary>
        public DateTime ResolutionTime { get; set; }

        ///<summary>
        /// ��������
        ///</summary>
        public String CurrencyCode { get; set; }
    }
}
