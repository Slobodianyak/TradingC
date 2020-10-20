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



namespace DAL.Tests
{
    [TestFixture]
    [Transaction(TransactionOption.RequiresNew), ComVisible(true)]
    public class OrderDALTest
    {
        [Test]
        public void CreateOrderTest()
        {
            OrderDAL dal = new OrderDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);



            var result = new OrderDTO
            {

                Order_Product_name = "Order_Product_name1",
                Order_Product_quantity = 2,
                Order_Product_value = 10,
                Order_Product_total_value = 100,
                Order_User_id = 4
            };

            result = dal.CreateOrder(result);
            Assert.IsTrue(result.Order_id >= 0, "returned ID should be more than zero");

        }
        [Test]
        public void GetOrderByIDTest()
        {
            OrderDAL dal = new OrderDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            var result = dal.GetOrderById(7);
            Assert.IsTrue(result.Order_id == 7, "returned ID does not match request");

        }

        [Test]
        public void DeleteOrderTest()
        {
            OrderDAL dal = new OrderDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            dal.DeleteOrder(7);

            Assert.IsTrue(dal.GetOrderById(7).Order_id != 7, "item still in db"); ;

        }
    }
}

