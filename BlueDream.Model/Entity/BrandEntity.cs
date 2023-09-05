using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 品牌表
    /// </summary>
    [SugarTable("t_brand")]
    public class BrandEntity : BaseEntity
    {
        /// <summary>
        /// 品牌ID
        /// </summary>
        [SugarColumn(ColumnName = "brand_id",IsPrimaryKey = true)]
        public long BrandID { get; set; }
        /// <summary>
        /// 简称
        /// </summary>
        [SugarColumn(ColumnName = "brand_short_name")]
        public string BrandShortName { get; set; }
        /// <summary>
        /// 中文名称
        /// </summary>
        [SugarColumn(ColumnName = "brand_cn")]
        public string BrandCn { get; set; }
        /// <summary>
        /// 英文名称
        /// </summary>
        [SugarColumn(ColumnName = "brand_en")]
        public string BrandEn { get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        [SugarColumn(ColumnName = "brand_logo")]
        public string BrandLogo { get; set; }
    }
}
