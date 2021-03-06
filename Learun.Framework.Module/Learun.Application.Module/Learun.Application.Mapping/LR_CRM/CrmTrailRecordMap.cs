using Learun.Application.CRM;
using System.Data.Entity.ModelConfiguration;

namespace  Learun.Application.Mapping
{
    /// <summary>
    /// 版 本 Learun-ADMS V7.0.6 力软敏捷开发框架
    /// Copyright (c) 2013-2020 上海力软信息技术有限公司
    /// 创 建：超级管理员
    /// 日 期：2017-07-11 11:20
    /// 描 述：跟进记录
    /// </summary>
    public class CrmTrailRecordMap : EntityTypeConfiguration<CrmTrailRecordEntity>
    {
        public CrmTrailRecordMap()
        {
            #region 表、主键
            //表
            this.ToTable("LR_CRM_TRAILRECORD");
            //主键
            this.HasKey(t => t.F_TrailId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}

