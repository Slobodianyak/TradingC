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
    class Order_ManagerT
    {
        [TestFixture]
        [Transaction(TransactionOption.RequiresNew), ComVisible(true)]
        public class Order_ManagerDALTest
        {



            [Test]
            public void CreateShipperTest()
            {
                Order_ManagerDAL dal = new Order_ManagerDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);



                var result = new Order_ManagerDTO
                {
                   Userid = 2,
                    O_M_frist_name = "fname",
                    O_M_last_name = "lname",
                    O_M_login = "login1",
                    O_M_e_mail = "email1",
                    salary = 10000,
                };

                result = dal.CreateOrder_Manager(result);
                Assert.IsTrue(result.O_M_id >= 0, "returned ID should be more than zero");

            }


            [Test]
            public void GetShipperByIDTest()
            {
                Order_ManagerDAL dal = new Order_ManagerDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
                var result = dal.GetOrder_ManagerById(13);
                Assert.IsTrue(result.O_M_id == 13, "returned ID does not match request");

            }

            [Test]
            public void DeleteShipperTest()
            {
                Order_ManagerDAL dal = new Order_ManagerDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
                dal.DeleteOrder_Manager(13);

                Assert.IsTrue(dal.GetOrder_ManagerById(13).O_M_id != 13, "item still in db"); ;

            }




            [Test]
            public void UpdateShipperTest()
            {
                Order_ManagerDAL dal = new Order_ManagerDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
                var shupper = dal.GetOrder_ManagerById(13);
                Order_ManagerDTO upd = new Order_ManagerDTO
                {
                    Userid = 2,
                    O_M_frist_name = "fname",
                    O_M_last_name = "lname",
                    O_M_login = "login1",
                    O_M_e_mail = "email1",
                    salary = 10000,
                };

                var result = dal.UpdateOrder_Manager(upd);

                Assert.IsTrue(result.O_M_e_mail == "Updated", "Order_Manager was not updated");

            }
        }
}
