using DAL.Concrete;
using DTO;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Configuration.Assemblies;
using System.EnterpriseServices;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BL.Solid;

namespace BL_tests.Tests
{
    [TestFixture]
    [Transaction(TransactionOption.RequiresNew), ComVisible(true)]
    class User_tests
    {
        [Test]
        public void AddItemTest()
        {
            ItemDAL itemDAL = new ItemDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            Order_ManagerDAL shipperDAL = new Order_ManagerDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            CustomerDAL customerDAL = new CustomerDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString); ;
            OrderDAL orderDAL = new OrderDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString); ;
            AddDAL addtoorderDAL = new AddDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            User result = new User(shipperDAL, itemDAL, customerDAL, orderDAL, addtoorderDAL);
            var item = new ItemDTO
            {
                Name = "BL Test",
                Value = 50,
            };



            var r = result.AddItem(item);
            Assert.IsTrue(r.Item_id != 0, "returned ID should be more than zero");
        }


        [Test]
        public void GetItemTest()
        {
            ItemDAL itemDAL = new ItemDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            Order_ManagerDAL shipperDAL = new ShipperDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            CustomerDAL customerDAL = new CustomerDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString); ;
            OrderDAL orderDAL = new OrderDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString); ;
            AddDAL addtoorderDAL = new AddDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            User result = new User(shipperDAL, itemDAL, customerDAL, orderDAL, addtoorderDAL);

            Assert.IsTrue(result.GetItem(4).Item_id == 2, "Cannot find the item");
        }


        [Test]
        public void UpdateItemTest()
        {
            ItemDAL itemDAL = new ItemDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            Order_ManagerDAL shipperDAL = new Order_ManagerDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            CustomerDAL customerDAL = new CustomerDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString); ;
            OrderDAL orderDAL = new OrderDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString); ;
            AddDAL addtoorderDAL = new AddDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            User result = new User(shipperDAL, itemDAL, customerDAL, orderDAL, addtoorderDAL);
            var item = new ItemDTO
            {
                Item_id = 32,
                Value = 25,
            };
            Assert.IsTrue(result.ChangeItem(item).Value == 25, "Item was not updated");


        }


        [Test]
        public void DeleteItemTest()
        {
            ItemDAL itemDAL = new ItemDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            Order_ManagerDAL shipperDAL = new Order_ManagerDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            CustomerDAL customerDAL = new CustomerDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString); ;
            OrderDAL orderDAL = new OrderDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString); ;
            AddDAL addtoorderDAL = new AddDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            User result = new User(shipperDAL, itemDAL, customerDAL, orderDAL, addtoorderDAL);
            result.RemoveItem(33);
            Assert.IsTrue(result.GetItem(33).Item_id != 27, "Item was not deleted");
        }


        [Test]
        public void LogTest()
        {
            ItemDAL itemDAL = new ItemDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            Order_ManagerDAL shipperDAL = new Order_ManagerDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            CustomerDAL customerDAL = new CustomerDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString); ;
            OrderDAL orderDAL = new OrderDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString); ;
            AddDAL addtoorderDAL = new AddDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            User result = new User(shipperDAL, itemDAL, customerDAL, orderDAL, addtoorderDAL);
            result.Log("TestShipper", "1234");
            Assert.IsTrue(result.Log("TestShipper", "1234") == true, "User was not logged");
        }

        [Test]
        public void AddShipperTest()
        {
            ItemDAL itemDAL = new ItemDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            Order_ManagerDAL shipperDAL = new Order_ManagerDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            CustomerDAL customerDAL = new CustomerDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString); ;
            OrderDAL orderDAL = new OrderDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString); ;
            AddDAL addtoorderDAL = new AddDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            User result = new User(shipperDAL, itemDAL, customerDAL, orderDAL, addtoorderDAL);

            var shipper = new Order_ManagerDTO
            {
                Login = "TestShipper2",
                Password = new TradingCWF.PasswordActions().PasswordEncryption("1234"),
                E_mail = "Test2",

            };

            shipper = result.AddOrder_Manager(shipper);
            Assert.IsTrue(shipper.O_M_id >= 0, "returned ID should be more than zero");

        }

        public void DeleteShipperTest()
        {
            ItemDAL itemDAL = new ItemDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            Order_ManagerDAL shipperDAL = new Order_ManagerDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            CustomerDAL customerDAL = new CustomerDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString); ;
            OrderDAL orderDAL = new OrderDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString); ;
            AddDAL addtoorderDAL = new AddDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            User result = new User(shipperDAL, itemDAL, customerDAL, orderDAL, addtoorderDAL);
            result.RemoveOrder_Manager(3);
            Assert.IsTrue(result.GetOrder_Manager(3).O_M_id != 4, "Shipper was not deleted");
        }

        [Test]
        public void GetShipperTest()
        {
            ItemDAL itemDAL = new ItemDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            Order_ManagerDAL shipperDAL = new Order_ManagerDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            CustomerDAL customerDAL = new CustomerDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString); ;
            OrderDAL orderDAL = new OrderDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString); ;
            AddDAL addtoorderDAL = new AddDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            User result = new User(shipperDAL, itemDAL, customerDAL, orderDAL, addtoorderDAL);
            result.GetOrder_Manager(2);
            Assert.IsTrue(result.GetOrder_Manager(2).ShipperID == 2, "Shipper was not found");
        }



        [Test]
        public void DeleteOrderTest()
        {
            ItemDAL itemDAL = new ItemDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            Order_ManagerDAL shipperDAL = new Order_ManagerDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            CustomerDAL customerDAL = new CustomerDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString); ;
            OrderDAL orderDAL = new OrderDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString); ;
            AddDAL addtoorderDAL = new AddDAL(ConfigurationManager.ConnectionStrings["Order_Manager"].ConnectionString);
            User result = new User(shipperDAL, itemDAL, customerDAL, orderDAL, addtoorderDAL);
            result.DeleteOrder(1);
            Assert.IsTrue(result.GetOrder(1).Order_id != 1, "Order was not deleted");
        }
    }
}
