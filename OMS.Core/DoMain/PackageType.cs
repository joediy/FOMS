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
    /// PackageType
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
    [Table("Package")]
    [Serializable]
    public class PackageType : ObjectBase<PackageType>
    {

        ///<summary>
        /// Id
        ///</summary>
        //public int Id { get; set; }

        ///<summary>
        /// ������
        ///</summary>
        public String PackageNo { get; set; }

        ///<summary>
        /// ��������
        ///</summary>
        public int OrderID { get; set; }

        ///<summary>
        /// �������
        ///</summary>
        public String OrderNo { get; set; }

        ///<summary>
        /// ��������
        ///</summary>
        public Double PackageWeight { get; set; }

        ///<summary>
        /// Ԥ������
        ///</summary>
        public Double ExpectedWeight { get; set; }

        ///<summary>
        /// ��
        ///</summary>
        public Double PackageLong { get; set; }

        ///<summary>
        /// ��
        ///</summary>
        public Double PackageWide { get; set; }

        ///<summary>
        /// ��
        ///</summary>
        public Double PackageHigh { get; set; }

        ///<summary>
        /// ����״̬
        ///</summary>
        public String PackageStatus { get; set; }

        ///<summary>
        /// ����ʱ��
        ///</summary>
        public DateTime ShippedTime { get; set; }

        ///<summary>
        /// ������
        ///</summary>
        public String TrackCode { get; set; }

        ///<summary>
        /// ������ʽ
        ///</summary>
        public String LogisticsMode { get; set; }

        ///<summary>
        /// ����ʱ��
        ///</summary>
        public DateTime CreateOn { get; set; }
    }
}
