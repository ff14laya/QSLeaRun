using Learun.Application.CRM;
using System.Data.Entity.ModelConfiguration;

namespace  Learun.Application.Mapping
{
    /// <summary>
    /// �� �� Learun-ADMS V7.0.6 �������ݿ������
    /// Copyright (c) 2013-2020 �Ϻ�������Ϣ�������޹�˾
    /// �� ������������Ա
    /// �� �ڣ�2017-07-11 11:30
    /// �� �����̻�����
    /// </summary>
    public class CrmChanceMap : EntityTypeConfiguration<CrmChanceEntity>
    {
        public CrmChanceMap()
        {
            #region ������
            //��
            this.ToTable("LR_CRM_CHANCE");
            //����
            this.HasKey(t => t.F_ChanceId);
            #endregion
            this.Property(t => t.F_Amount).HasPrecision(18, 6);
            #region ���ù�ϵ
            #endregion
        }
    }
}

