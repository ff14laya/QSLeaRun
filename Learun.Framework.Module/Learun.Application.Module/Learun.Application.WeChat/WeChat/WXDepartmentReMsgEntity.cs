namespace Learun.Application.WeChat.WeChat
{
    /// <summary>
    /// 版 本 Learun-ADMS V6.1.6.0 力软敏捷开发框架
    /// Copyright (c) 2013-2017 上海力软信息技术有限公司
    /// 创 建：超级管理员
    /// 日 期：2017-09-22 12:01
    /// 描 述：创建部门返回类
    /// </summary>
    public class WXDepartmentReMsgEntity
    {
        /// <summary>
        /// 错误码
        /// </summary>
        public int errcode { get; set; }
        /// <summary>
        /// 错误内容
        /// </summary>
        public string errmsg { get; set; }
        /// <summary>
        /// 创建的部门id
        /// </summary>
        public int? id { get; set; }
    }
}
