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
    public class UserDAL:IUserDAL
    {
        private string connectionString;

        public UserDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<UserDTO> GetAllUsers()
        {
            throw new NotImplementedException();
        }


        public UserDTO GetUserByid(int User_id)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                conn.Open();
                UserDTO user = new UserDTO();

                comm.CommandText = $"select * from User where User_id=@User_id";
                comm.Parameters.AddWithValue("@User_id", User_id);
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {

                    user = new UserDTO
                    {
                        User_id = Convert.ToInt32(reader["User_id"]),
                        User_login = reader["User_login"].ToString(),
                        User_e_mail = reader["User_e_mail"].ToString(),
                        User_password = reader["User_password"].ToString(),
                        Is_User_Order_Manager = reader["Is_User_Order_Manager"].ToString(),
                    };
                }

                return user;
            }
        }

        public void DeleteUser(int User_id)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "delete from [User] where User_id = @User_id";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@User_id", User_id);
                conn.Open();

                comm.ExecuteNonQuery();
            }
        }

        public UserDTO UpdateUser(UserDTO User)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "update [User] set User_login= @User_login, User_e_mail=@User_e_mail, User_password=@User_password, Is_User_Order_Manager=@Is_User_Order_Manager where User_id = @User_id";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@User_id", User.User_id);
                comm.Parameters.AddWithValue("@User_login", User.User_login);
                comm.Parameters.AddWithValue("@User_e_mail", User.User_e_mail);
                comm.Parameters.AddWithValue("@User_password", User.User_password);
                comm.Parameters.AddWithValue("@Is_User_Order_Manager", User.Is_User_Order_Manager);
                conn.Open();

                User.User_id = Convert.ToInt32(comm.ExecuteScalar());


                return User;
            }
        }


        public UserDTO CreateUser(UserDTO User)
        {

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "insert into [User] (User_login, , User_e_mail, User_password,Is_User_Order_Manager) output INSERTED.User_id values (@User_login, @User_e_mail, @User_password,@Is_User_Order_Manager)";
                comm.Parameters.Clear();

                comm.Parameters.AddWithValue("@User_id", User.User_id);
                comm.Parameters.AddWithValue("@User_login", User.User_login);
                comm.Parameters.AddWithValue("@User_e_mail", User.User_e_mail);
                comm.Parameters.AddWithValue("@User_password", User.User_password);
                comm.Parameters.AddWithValue("@Is_User_Order_Manager", User.Is_User_Order_Manager);
                conn.Open();

                User.User_id = Convert.ToInt32(comm.ExecuteScalar());
                return User;
            }
        }


    }
}

