using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IOrder_listDAL
    {
        Order_listDTO CreateOrder_list(Order_listDTO orderlist);
        void DeleteOrder_list(int O_L_id);
        Order_listDTO GetOrderById(int O_L_id);
        List<Order_listDTO> GetAllOrders(int orderlist);
    }
}
