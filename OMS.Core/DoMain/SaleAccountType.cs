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
    /// SaleAccountType
    /// �����˻���
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
    [Table("SaleAccount")]
    [Serializable]
    public class SaleAccountType : ObjectBase<SaleAccountType>
    {

        ///<summary>
        /// Id
        ///</summary>
        //public int Id { get; set; }

        ///<summary>
        /// �û���
        ///</summary>
        public String UserName { get; set; }

        ///<summary>
        /// ������
        ///</summary>
        public String AccountManager { get; set; }

        ///<summary>
        /// �绰
        ///</summary>
        public String ManagerPhone { get; set; }

        ///<summary>
        /// Email
        ///</summary>
        public String ManagerEmail { get; set; }

        ///<summary>
        /// ApiToken
        ///</summary>
        public String ApiToken { get; set; }

        ///<summary>
        /// ����
        ///</summary>
        public String Description { get; set; }

        ///<summary>
        /// �˻�״̬
        ///</summary>
        public String AccountStatus { get; set; }

        ///<summary>
        /// ƽ̨�˻�
        ///</summary>
        public String PlatformCode { get; set; }
    }
}
