using Learun.Application.IM;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>
    /// 版 本 Learun-ADMS V7.0.6 力软敏捷开发框架
    /// Copyright (c) 2013-2020 上海力软信息技术有限公司
    /// 创建人：力软-框架开发组
    /// 日 期：2018.05.31
    /// 描 述：即时通讯消息内容
    /// </summary>
    public class IMMsgMap : EntityTypeConfiguration<IMMsgEntity>
    {
        public IMMsgMap()
        {
            #region 表、主键
            //表
            this.ToTable("LR_IM_MSG");
            //主键
            this.HasKey(t => t.F_MsgId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
