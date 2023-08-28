using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 货币表
    /// </summary>
    [SugarTable("t_currency")]
    public class CurrencyEntity : BaseEntity
    {
        /// <summary>
        /// 货币编码
        /// </summary>
        [SugarColumn(ColumnName = "currency_code",IsPrimaryKey = true)]
        public string CurrencyCode { get; set; }
        /// <summary>
        /// 货币名称
        /// </summary>
        [SugarColumn(ColumnName = "currency_name")]
        public string CurrencyName { get; set; }
    }
}
