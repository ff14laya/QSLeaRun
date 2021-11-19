﻿using Learun.Application.TwoDevelopment.LR_CodeDemo;
using System.Data.Entity.ModelConfiguration;

namespace  Learun.Application.Mapping
{
    /// <summary>
    /// 版 本 Learun-ADMS V7.0.6 力软敏捷开发框架
    /// Copyright (c) 2013-2020 上海力软信息技术有限公司
    /// 创 建：超级管理员
    /// 日 期：2019-09-26 11:35
    /// 描 述：付款单
    /// </summary>
    public class LR_ERP_PaymentInfoMap : EntityTypeConfiguration<LR_ERP_PaymentInfoEntity>
    {
        public LR_ERP_PaymentInfoMap()
        {
            #region 表、主键
            //表
            this.ToTable("LR_ERP_PAYMENTINFO");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}

