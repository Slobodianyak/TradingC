using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IOrderDAL
    {
        OrderDTO CreateOrder(OrderDTO order);
        OrderDTO GetOrderById(int Order_id);
        List<OrderDTO> GetAllOrders(int ShipperIDKEY);
        void DeleteOrder(int Order_id);
    }
}
