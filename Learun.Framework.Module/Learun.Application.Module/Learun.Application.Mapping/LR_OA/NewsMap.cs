using Learun.Application.OA;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>
    /// 版 本 Learun-ADMS V7.0.6 力软敏捷开发框架
    /// Copyright (c) 2013-2020 上海力软信息技术有限公司
    /// 创建人：力软-框架开发组
    /// 日 期：2017.04.17
    /// 描 述：新闻公告
    /// </summary>
    public class NewsMap : EntityTypeConfiguration<NewsEntity>
    {
        public NewsMap()
        {
            #region 表、主键
            //表
            this.ToTable("LR_OA_NEWS");
            //主键
            this.HasKey(t => t.F_NewsId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
