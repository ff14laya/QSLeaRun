﻿using Learun.Application.Base.CodeSchemaModule;
using System.Data.Entity.ModelConfiguration;

namespace  Learun.Application.Mapping
{
    /// <summary>
    /// 版 本 Learun-ADMS V7.0.6 力软敏捷开发框架
    /// Copyright (c) 2013-2020 上海力软信息技术有限公司
    /// 创 建：超级管理员
    /// 日 期：2019-03-01 11:09
    /// 描 述：代码模板
    /// </summary>
    public class LR_Base_CodeSchemaMap : EntityTypeConfiguration<LR_Base_CodeSchemaEntity>
    {
        public LR_Base_CodeSchemaMap()
        {
            #region 表、主键
            //表
            this.ToTable("LR_BASE_CODESCHEMA");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}

