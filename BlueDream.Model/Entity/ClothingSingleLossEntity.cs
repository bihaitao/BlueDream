using BlueDream.Enum;
using SqlSugar;

namespace BlueDream.Model
{
    /// <summary>
    /// 单耗表
    /// </summary>
    [SugarTable("t_clothing_single_loss")]
    public class ClothingSingleLossEntity : BaseEntity
    {
        /// <summary>
        /// 单耗ID
        /// </summary>
        [SugarColumn(ColumnName = "item_loss_id",IsPrimaryKey = true)]
        public Int64 ItemLossID { get; set; }
        /// <summary>
        /// 合同采购项ID
        /// </summary>
        [SugarColumn(ColumnName = "purchase_item_id")]
        public Int64 PurchaseItemID { get; set; }
        /// <summary>
        /// 部位
        /// </summary>
        [SugarColumn(ColumnName = "part")]
        public String Part { get; set; }
        /// <summary>
        /// 段长 cm
        /// </summary>
        [SugarColumn(ColumnName = "length")]
        public Double Length { get; set; }
        /// <summary>
        /// 损耗 cm
        /// </summary>
        [SugarColumn(ColumnName = "loss")]
        public Double Loss { get; set; }
        /// <summary>
        /// 克重 g
        /// </summary>
        [SugarColumn(ColumnName = "weight")]
        public Double Weight { get; set; }
        /// <summary>
        /// 有效宽幅 cm
        /// </summary>
        [SugarColumn(ColumnName = "effective_width")]
        public Double EffectiveWidth { get; set; }
        /// <summary>
        /// 毛幅 cm
        /// </summary>
        [SugarColumn(ColumnName = "preserve_width")]
        public Double PreserveWidth { get; set; }
        /// <summary>
        /// 件数
        /// </summary>
        [SugarColumn(ColumnName = "number")]
        public int Number { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "single_loss")]
        public Double SingleLoss { get; set; }
 
    }
}
