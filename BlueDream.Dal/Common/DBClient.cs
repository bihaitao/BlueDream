using BlueDream.Enum;
using BlueDream.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueDream.Dal
{
    /// <summary>
    /// 数据库对象
    /// </summary>
    public class DBClient
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public string ConnectionString { set; get; } = "";

        /// <summary>
        /// 删除基类赋值，标记继承自BaseEntity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public IUpdateable<T> DeleteInstance<T>(T p_Type) where T : BaseEntity, new()
        { 
            p_Type.UpdateTime = DateTime.Now;
            //p_Type.UpdateUser = LoginUserModel.UserNickName;
            //p_Type.UpdateUserID = LoginUserModel.UserID;
            p_Type.DataState = DataStateEnum.Delete;

            return Instance.Updateable(p_Type);
        }

        /// <summary>
        /// 删除基类赋值，标记继承自BaseEntity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public IUpdateable<T> DeleteInstance<T>(List<T> p_t) where T : BaseEntity, new()
        {
            foreach (T t_Item in p_t)
            {
                t_Item.UpdateTime = DateTime.Now;
                //t_Item.UpdateUser = LoginUserModel.UserNickName;
                //t_Item.UpdateUserID = LoginUserModel.UserID;
                t_Item.DataState = DataStateEnum.Delete;
            }
            return Instance.Updateable(p_t);
        }


        /// <summary>
        /// 更新基类赋值，标记继承自BaseEntity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public IUpdateable<T> UpdateInstance<T>(T p_Type) where T : BaseEntity, new()
        {
            p_Type.UpdateTime = DateTime.Now;
            //p_Type.UpdateUser = LoginUserModel.UserNickName;
            //p_Type.UpdateUserID = LoginUserModel.UserID;
            p_Type.DataState = DataStateEnum.Valid;

            return Instance.Updateable(p_Type);
        }

        /// <summary>
        /// 更新基类赋值，标记继承自BaseEntity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public IUpdateable<T> UpdateInstance<T>(List<T> p_t) where T : BaseEntity, new()
        {
            foreach (T t_Item in p_t)
            {
                t_Item.UpdateTime = DateTime.Now;
                //t_Item.UpdateUser = LoginUserModel.UserNickName;
                //t_Item.UpdateUserID = LoginUserModel.UserID;
                t_Item.DataState = DataStateEnum.Valid;
            }
            return Instance.Updateable(p_t);
        }

        /// <summary>
        /// 新增基类赋值，标记继承自BaseEntity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public IInsertable<T> InsertInstance<T>(T p_t) where T : BaseEntity,new()
        {
            p_t.CreateTime = DateTime.Now;
            //p_t.CreateUser = LoginUserModel.UserNickName;
            //p_t.CreateUserID = LoginUserModel.UserID;
            p_t.UpdateTime = DateTime.Now;
            //p_t.UpdateUser = LoginUserModel.UserNickName;
            //p_t.UpdateUserID = LoginUserModel.UserID;
            p_t.DataState = DataStateEnum.Valid;

            return Instance.Insertable(p_t);
        }

        /// <summary>
        /// 新增基类赋值，标记继承自BaseEntity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public IInsertable<T> InsertInstance<T>(List<T> p_t) where T : BaseEntity, new()
        {
            foreach (T t_Item in p_t) {
                t_Item.CreateTime = DateTime.Now;
                //t_Item.CreateUser = LoginUserModel.UserNickName;
                //t_Item.CreateUserID = LoginUserModel.UserID;
                t_Item.UpdateTime = DateTime.Now;
                //t_Item.UpdateUser = LoginUserModel.UserNickName;
                //t_Item.UpdateUserID = LoginUserModel.UserID;
                t_Item.DataState = DataStateEnum.Valid;
            }
            return Instance.Insertable(p_t);
        }

        /// <summary>
        /// 声明内部SqlSugar实例
        /// </summary>
        internal SqlSugarClient Instance { set; get; }

        /// <summary>
        /// 开启事务
        /// </summary>
        public void BeginTran()
        {
            Instance.Ado.BeginTran();
        }

        /// <summary>
        /// 提交事务
        /// </summary>
        public void CommitTran()
        {
            Instance.Ado.CommitTran();
        }

        /// <summary>
        /// 回滚事务
        /// </summary>
        public void RollbackTran()
        {
            Instance.Ado.RollbackTran();
        }
    }
}
