﻿using Learun.Application.TwoDevelopment.LR_CodeDemo;
using System.Data.Entity.ModelConfiguration;

namespace  Learun.Application.Mapping
{
    /// <summary>
    /// 版 本 Learun-ADMS V7.0.6 力软敏捷开发框架
    /// Copyright (c) 2013-2020 上海力软信息技术有限公司
    /// 创 建：超级管理员
    /// 日 期：2019-09-26 09:44
    /// 描 述：收款单
    /// </summary>
    public class LR_ERP_ReceiptInfoDetailMap : EntityTypeConfiguration<LR_ERP_ReceiptInfoDetailEntity>
    {
        public LR_ERP_ReceiptInfoDetailMap()
        {
            #region 表、主键
            //表
            this.ToTable("LR_ERP_RECEIPTINFODETAIL");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}

