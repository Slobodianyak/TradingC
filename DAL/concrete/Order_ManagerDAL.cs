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
    public class Order_ManagerDAL
    {
        private string connectionString;

        public Order_ManagerDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public Order_ManagerDTO GetOrder_ManagerById(int O_M_id)
        {

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                conn.Open();
                Order_ManagerDTO Order_Manager = new Order_ManagerDTO();

                comm.CommandText = $"select * from Order_Manager where O_M_id=@O_M_id";
                comm.Parameters.AddWithValue("@O_M_id", O_M_id);
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {

                    Order_Manager = new Order_ManagerDTO
                    {
                        O_M_id = Convert.ToInt32(reader["O_M_id"]),
                        Userid = Convert.ToInt32(reader["Userid"]),
                        O_M_frist_name = reader["O_M_frist_name"].ToString(),
                        O_M_last_name = reader["O_M_last_name"].ToString(),
                        O_M_login = reader["O_M_login"].ToString(),
                        O_M_e_mail = reader["O_M_e_mail"].ToString(),
                        O_M_password = (byte[])(reader["O_M_password"]),
                        salary = Convert.ToInt32(reader["salary"]),
                    };
                }

                return Order_Manager;
            }
        }





        public Order_ManagerDTO CreateOrder_Manager(Order_ManagerDTO Order_Manager)
        {

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "insert into Order_Manager (O_M_frist_name, O_M_last_name, O_M_login, O_M_e_mail,O_M_password,salary) output INSERTED.O_M_id values (@O_M_frist_name,@O_M_last_name, @O_M_login, @O_M_e_mail,@O_M_password,salary)";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@O_M_frist_name", Order_Manager.O_M_frist_name);
                comm.Parameters.AddWithValue("@O_M_last_name", Order_Manager.O_M_last_name);
                comm.Parameters.AddWithValue("@O_M_login", Order_Manager.O_M_login);
                comm.Parameters.AddWithValue("@O_M_e_mail", Order_Manager.O_M_e_mail);
                comm.Parameters.AddWithValue("@O_M_password", Order_Manager.O_M_password);
                comm.Parameters.AddWithValue("@salary", Order_Manager.salary);
                conn.Open();

                Order_Manager.O_M_id = Convert.ToInt32(comm.ExecuteScalar());
                return Order_Manager;
            }
        }

        public Order_ManagerDTO UpdateOrder_Manager(Order_ManagerDTO Order_Manager)
        {

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "update into Order_Manager (O_M_frist_name, O_M_last_name, O_M_login, O_M_e_mail,O_M_password,salary) output INSERTED.O_M_id values (@O_M_frist_name,@O_M_last_name, @O_M_login, @O_M_e_mail,@O_M_password,salary)";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@O_M_frist_name", Order_Manager.O_M_frist_name);
                comm.Parameters.AddWithValue("@O_M_last_name", Order_Manager.O_M_last_name);
                comm.Parameters.AddWithValue("@O_M_login", Order_Manager.O_M_login);
                comm.Parameters.AddWithValue("@O_M_e_mail", Order_Manager.O_M_e_mail);
                comm.Parameters.AddWithValue("@O_M_password", Order_Manager.O_M_password);
                comm.Parameters.AddWithValue("@salary", Order_Manager.salary);
                conn.Open();

                Order_Manager.O_M_id = Convert.ToInt32(comm.ExecuteScalar());
                return Order_Manager;
            }
        }

        public void DeleteOrder_Manager(int O_M_id)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "delete from Order_Manager where O_M_id = @O_M_id";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@O_M_id", O_M_id);
                conn.Open();

                comm.ExecuteNonQuery();
            }
        }

    }

}
