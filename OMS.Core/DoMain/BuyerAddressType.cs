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
    /// BuyerAddressType
    /// ��ҵ�ַ��
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
    [Table("BuyerAddress")]
    [Serializable]
    public class BuyerAddressType : ObjectBase<BuyerAddressType>
    {

        ///<summary>
        /// ������ʶ
        ///</summary>
        //public int Id { get; set; }

        ///<summary>
        /// ��Ҵ���
        ///</summary>
        public string BuyerId { get; set; }

        ///<summary>
        /// �������
        ///</summary>
        public String BuyerCode { get; set; }

        ///<summary>
        /// ��ϵ��
        ///</summary>
        public String ContactMan { get; set; }

        ///<summary>
        /// �ʱ�
        ///</summary>
        public String PostCode { get; set; }

        ///<summary>
        /// ��������
        ///</summary>
        public String Email { get; set; }

        ///<summary>
        /// �ֻ�
        ///</summary>
        public String Phone { get; set; }

        ///<summary>
        /// �ֵ�
        ///</summary>
        public String Street { get; set; }

        ///<summary>
        /// ��
        ///</summary>
        public String County { get; set; }

        ///<summary>
        /// ����
        ///</summary>
        public String City { get; set; }

        ///<summary>
        /// ��/ʡ
        ///</summary>
        public String StateOrProvince { get; set; }

        ///<summary>
        /// ����
        ///</summary>
        public String Country { get; set; }

        ///<summary>
        /// ���Ҵ���
        ///</summary>
        public String CountryCode { get; set; }
    }
}
