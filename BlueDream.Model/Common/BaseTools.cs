
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.Model.Common
{
    public class BaseTools
    {
        public static void InitBase(BaseEntity p_BaseEntity)
        {
            p_BaseEntity.UpdateTime = DateTime.Now;
            p_BaseEntity.UpdateUser = "";
            p_BaseEntity.UpdateUserID = 0;
            p_BaseEntity.CreateTime = DateTime.Now;
            p_BaseEntity.CreateUser = "";
            p_BaseEntity.CreateUserID = 0;
            p_BaseEntity.DataState = Enum.DataStateEnum.Valid;
        }
    }
}
