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
    /// DisputeApproachType
    /// ���״���ʽ��
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
    [Table("DisputeApproach")]
    [Serializable]
    public class DisputeApproachType : ObjectBase<DisputeApproachType>
    {

        ///<summary>
        /// ������ʶ
        ///</summary>
        //public int Id { get; set; }

        ///<summary>
        /// ����ʽ
        ///</summary>
        public String ApproachName { get; set; }

    }
}
