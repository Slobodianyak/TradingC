using DAL.interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.concrete
{
    public class OrderDAL:IOrderDAL
    {
        private string connectionString;

        public OrderDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public OrderDTO CreateOrder(OrderDTO order)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "insert into [Order] (Order_Product_name, Order_Product_quantity, Order_Product_value, Order_Product_total_value, Order_User_id) output INSERTED.Order_id values (@Order_Product_name, @Order_Product_quantity, @Order_Product_value, @Order_Product_total_value, @Order_User_id)";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@Order_Product_name", order.Order_Product_name);
                comm.Parameters.AddWithValue("@Order_Product_quantity", order.Order_Product_quantity);
                comm.Parameters.AddWithValue("@Order_Product_value", order.Order_Product_value);
                comm.Parameters.AddWithValue("@Order_Product_total_value", order.Order_Product_total_value);
                comm.Parameters.AddWithValue("@Order_User_id", order.Order_User_id);
                conn.Open();

                order.Order_id = Convert.ToInt32(comm.ExecuteScalar());
                return order;
            }
        }

        public void DeleteOrder(int Order_id)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "delete from [Order_list] where Order_id=@O_L_id delete from [Order] where Order_id = @Order_id";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@Order_id", Order_id);
                conn.Open();

                comm.ExecuteNonQuery();
            }
        }

        public OrderDTO GetOrderById(int Order_id)
        {

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                conn.Open();
                OrderDTO order = new OrderDTO();

                comm.CommandText = "select * from [Order] where Order_id=@Order_id";

                comm.Parameters.AddWithValue("@Order_id", Order_id);
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {

                    order = new OrderDTO
                    {
                        Order_id = Convert.ToInt32(reader["Order_id"]),
                        Order_Product_name = Convert.ToString(reader["Order_Product_name"]),
                        Order_Product_quantity = Convert.ToInt32(reader["Order_Product_quantity"]),
                        Order_Product_value = Convert.ToInt32(reader["Order_Product_value"]),
                        Order_Product_total_value = Convert.ToInt32(reader["Order_Product_total_value"]),
                        Order_User_id = Convert.ToInt32(reader["Order_User_id"]),
                    };
                }

                return order;
            }
        }



        public List<OrderDTO> GetAllOrders(int ShipperIDKEY)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "select * from [Order]";
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();

                List<OrderDTO> orders = new List<OrderDTO>();
                while (reader.Read())
                {

                    orders.Add(new OrderDTO
                    {
                        Order_id = Convert.ToInt32(reader["Order_id"]),
                        Order_Product_name = Convert.ToString(reader["Order_Product_name"]),
                        Order_Product_quantity = Convert.ToInt32(reader["Order_Product_quantity"]),
                        Order_Product_value = Convert.ToInt32(reader["Order_Product_value"]),
                        Order_Product_total_value = Convert.ToInt32(reader["Order_Product_total_value"]),
                        Order_User_id = Convert.ToInt32(reader["Order_User_id"]),
                    });
                }

                return orders;
            }
        }
    }
}
