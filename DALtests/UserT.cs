using DAL.concrete;
using DTO;
using Microsoft.IdentityModel.Protocols;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.EnterpriseServices;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace DALtests
{
    class UserT
    {
        [TestFixture]
        [Transaction(TransactionOption.RequiresNew), ComVisible(true)]
        public class UserDALTest
        {

            [Test]
            public void CreateUserTest()
            {
                UserDAL dal = new UserDAL(ConfigurationManager.ConnectionStrings["User"].ConnectionString);




                var result = new UserDTO
                {

                    User_login = "login1",
                    User_e_mail = "email1",
                    User_password = "password1",
                    Is_User_Order_Manager = "Yes,"
                };

                result = dal.CreateUser(result);
                Assert.IsTrue(result.User_id >= 0, "returned ID should be more than zero");

            }


            [Test]
            public void GetUserByIDTest()
            {
                UserDAL dal = new UserDAL(ConfigurationManager.ConnectionStrings["User"].ConnectionString);
                var result = dal.GetUserByid(3);
                Assert.IsTrue(result.User_id == 3, "returned ID does not match request");
                //Assert.IsNull()
            }

            [Test]
            public void DeleteUserTest()
            {
                UserDAL dal = new UserDAL(ConfigurationManager.ConnectionStrings["Shipper"].ConnectionString);
                dal.DeleteUser(3);

                Assert.IsTrue(dal.GetUserByid(3).User_id != 3, "item still in db"); ;

            }
            [Test]
            public void UpdateUserTest()
            {
                UserDAL dal = new UserDAL(ConfigurationManager.ConnectionStrings["Shipper"].ConnectionString);

                UserDTO upd = new UserDTO
                {
                    User_id = 4,
                    User_login = "login1",
                    User_e_mail = "email1",
                    User_password = "password1",
                    Is_User_Order_Manager = "Yes,"
                };

                var result = dal.UpdateUser(upd);

                Assert.IsTrue(result.User_e_mail == "email1", "User was not updated");

            }



        }
    }
}
