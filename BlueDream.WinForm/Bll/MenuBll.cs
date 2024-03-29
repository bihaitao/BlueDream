﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.WinForm
{
    public class MenuBll
    {
     

        public static List<MenuModel> GetMenu()
        {
            List<MenuModel> m_Result = new List<MenuModel>();

            MenuModel m_MenuModel_Purchase = new MenuModel()
            {
                Name = "采购管理",
                Code = "Purchase"
            };

            m_Result.Add(m_MenuModel_Purchase);

            m_MenuModel_Purchase.SubMenus.Add(new MenuModel()
            {
                Name = "采购单管理",
                Code = "OrderListForm",
                FormFullName = typeof(BlueDream.WinForm.OrderListForm).FullName,
            });

            m_MenuModel_Purchase.SubMenus.Add(new MenuModel()
            {
                Name = "采购项列表",
                Code = "OrderItemForm",
                FormFullName = typeof(BlueDream.WinForm.OrderItemForm).FullName,
            });
             
            m_MenuModel_Purchase.SubMenus.Add(new MenuModel()
            {
                Name = "采购明细列表",
                Code = "OrderDetailForm",
                FormFullName = typeof(BlueDream.WinForm.OrderDetailForm).FullName,
            });


            MenuModel m_MenuModel_Sale = new MenuModel()
            {
                Name = "销售管理",
                Code = "Sale"
            };

            m_Result.Add(m_MenuModel_Sale);

            m_MenuModel_Sale.SubMenus.Add(new MenuModel()
            {
                Name = "销售单",
                Code = "SaleOrder",
                FormFullName = typeof(BlueDream.WinForm.SaleForm).FullName,
            });

            return m_Result;
           

        }
    }
}
