using DAL.interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL.interfaces
{
    public interface IOrder_ManagerDAL
    {
        Order_ManagerDTO CreateOrder_Manager(Order_ManagerDTO Order_Manager);
        Order_ManagerDTO GetOrder_ManagerById(int Order_ManagerID);
        Order_ManagerDTO UpdateOrder_Manager(Order_ManagerDTO Order_Manager);
        void DeleteOrder_Manager(int Order_ManagerID);
    }
}
