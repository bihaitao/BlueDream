using BlueDream.Common;
using BlueDream.Enum;
using Newtonsoft.Json;
using SqlSugar;
using System;

namespace BlueDream.Model
{
    /// <summary>
    /// 实体基础类
    /// </summary>
    public class BaseEntity
    { 
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "create_user")]
        public String CreateUser { get; set; } = "";
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "create_user_id")]
        public Int64 CreateUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "create_time")]
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "update_user")]
        public String UpdateUser { get; set; } = "";
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "update_user_id")]
        public Int64 UpdateUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "update_time")]
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "data_state")]
        public DataStateEnum DataState { get; set; }



        //[JsonIgnore][SugarColumn(IsIgnore = true)]
 

        /// <summary>
        /// 初始化用户对象
        /// </summary>
        /// <param name="p_LoginUserModel"></param>
        public void InitNewModel(LoginUserModel p_LoginUserModel)
        {
            CreateTime = DateTime.Now;
            CreateUser = p_LoginUserModel.UserNickName;
            CreateUserID = p_LoginUserModel.UserID;
            UpdateTime = DateTime.Now;
            UpdateUser = p_LoginUserModel.UserNickName;
            UpdateUserID = p_LoginUserModel.UserID;
            DataState = DataStateEnum.Valid;

            SystemTools.InitModel(this);
        }


      
        /// <summary>
        /// 序列化
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return JsonTools.GetJson(this);
        }
    }
}
