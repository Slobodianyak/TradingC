using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IUserDAL
    {
        List<UserDTO> GetAllUsers();
        UserDTO GetUserByid(int User_id);
        void DeleteUser(int User_id);
        UserDTO CreateUser(UserDTO user);
        UserDTO UpdateUser(UserDTO user);
    }
}
