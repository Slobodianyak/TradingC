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
    public class Order_listDAL:IOrder_listDAL
    {
        private string connectionString;

        public Order_listDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Order_listDTO CreateOrder_list(Order_listDTO orderlist)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "insert into Order_list (O_L_id, O_L_id, Provider_id, Order_list_O_M_id) output INSERTED.O_L_id values (@O_L_id, @O_L_id, @Provider_id, @Order_list_O_M_id)";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@O_L_id", orderlist.O_L_id);
                comm.Parameters.AddWithValue("@O_L_id", orderlist.O_L_id);
                comm.Parameters.AddWithValue("@Provider_id", orderlist.Provider_id);
                comm.Parameters.AddWithValue("@Order_list_O_M_id", orderlist.Order_list_O_M_id);
                conn.Open();

                orderlist.O_L_id = Convert.ToInt32(comm.ExecuteScalar());
                return orderlist;
            }
        }

        public void DeleteOrder_list(int O_L_id)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "delete from Order_list where O_L_id=@O_L_id delete from Order_list where O_L_id = @O_L_id";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@O_L_id", O_L_id);
                conn.Open();

                comm.ExecuteNonQuery();
            }
        }

        public Order_listDTO GetOrderById(int O_L_id)
        {

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                conn.Open();
                Order_listDTO orderlist = new Order_listDTO();

                comm.CommandText = "select * from [Order] where O_L_id=@O_L_id";

                comm.Parameters.AddWithValue("@O_L_id", O_L_id);
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {

                    orderlist = new Order_listDTO
                    {
                        O_L_id = Convert.ToInt32(reader["O_L_id"]),
                        Order_id = Convert.ToInt32(reader["Order_id"]),
                        Provider_id = Convert.ToInt32(reader["Provider_id"]),
                        Order_list_O_M_id = Convert.ToInt32(reader["Order_list_O_M_id"]),
                    };
                }

                return orderlist;
            }
        }

        public List<Order_listDTO> GetAllOrders(int orderlist)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "select * from [Order]";
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();

                List<Order_listDTO> orders = new List<Order_listDTO>();
                while (reader.Read())
                {

                    orders.Add(new Order_listDTO
                    {
                        O_L_id = Convert.ToInt32(reader["O_L_id"]),
                        Order_id = Convert.ToInt32(reader["Order_id"]),
                        Provider_id = Convert.ToInt32(reader["Provider_id"]),
                        Order_list_O_M_id = Convert.ToInt32(reader["Order_list_O_M_id"]),
                    });
                }

                return orders;
            }
        }
    }
}

