using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// Ȩ�ޱ�
    /// </summary>
    [SugarTable("t_right")]
    public class RightEntity:BaseEntity
    {
        /// <summary>
        /// Ȩ��ID
        /// </summary>
        [SugarColumn(ColumnName = "rigth_id", IsPrimaryKey = true)]
        public long RigthID { get; set; }
        /// <summary>
        /// Ȩ��Key
        /// </summary>
        [SugarColumn(ColumnName = "right_key")]
        public string RightKey { get; set; } = "";
        /// <summary>
        /// Ȩ������
        /// </summary>
        [SugarColumn(ColumnName = "right_name")]
        public string RightName { get; set; } = "";
        /// <summary>
        /// ע��
        /// </summary>
        [SugarColumn(ColumnName = "info")]
        public string Info { get; set; } = "";
    }
}
