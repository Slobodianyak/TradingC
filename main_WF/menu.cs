using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Solid;
using DAL.Concrete;
using DAL.Interfaces;
using DTO;
using BL;
using System.Threading;
using System.Windows.Forms;

namespace main
{
    public class menu
    {
        //private string connectionString;

        //public Menu(string connectionString)
        //{
        //    this.connectionString = connectionString;
        //}
        //public void MENU(int user)
        //{
        //    string conn = ConfigurationManager.ConnectionStrings["Shipper"].ConnectionString;
        //    ConsoleProgramFunctions Login = new ConsoleProgramFunctions(connectionString);
        //    ItemDAL itemD = new ItemDAL(conn);
        //    AddDAL addD = new AddDAL(conn);
        //    CustomerDAL customerD = new CustomerDAL(conn);
        //    OrderDAL orderD = new OrderDAL(conn);
        //    Order_ManagerDAL shipperD = new Order_ManagerDAL(conn);


        //    Item item = new Item(itemD);
        //    Add add = new Add(addD);
        //    Customer customer = new Customer(customerD);
        //    Order order = new Order(orderD);
        //    Order_Manager order_manager = new Order_Manager(order_managerD);




            //Console.Clear();

            //if (user > 0)
            //{
            //    Console.WriteLine($"WELCOME  {shipper.GetShipper(user).Login}");
            //    Console.WriteLine("CHOOSE OPTION TO CONTINUE:\n" + "1-WORK WITH ITEMS\n" + "2-WORK WITH ORDERS\n" + "3-SHOW CUSTOMERS\n" + "4-SIGH OUT\n" + "ANYTHING ELSE TO CLOSE PROGRAM\n" + "MY OPTION:");
            //    int choice = Convert.ToInt32(Console.ReadLine());
            //    Console.Clear();
            //    if (choice == 1)
            //    {
            //        item.ShowItems();
            //        Console.WriteLine("\n PRESS \n 1-TO FIND ITEM BY ID\n" + "2-TO GET ITEMS SORTED \n 3- TO ADD NEW ITEM \n ANYTHING ELSE TO RETURN TO MENU\n MY OPTION:");
            //        choice = Convert.ToInt32(Console.ReadLine());
            //        Console.Clear();
            //        if (choice == 1)
            //        {
            //            Console.WriteLine("ENTER ITEM ID TO SHOW:");
            //            int ItemID = Convert.ToInt32(Console.ReadLine());
            //            item.GetItem(ItemID);
            //            Console.WriteLine("ENTER 1 TO DELETE OR 2 TO UPDATE OR ANYTHING ELSE TO RETURN TO MENU:");
            //            choice = Convert.ToInt32(Console.ReadLine());
            //            if (choice == 1)
            //            {
            //                Console.WriteLine("ITEM {ItemID} WAS SUCCESSFULLY DELETED\n");

            //                item.RemoveItem(ItemID);
            //                Console.WriteLine("PRESS ANYTHING TO RETURN TO MENU");
            //                Console.ReadLine();
            //                MENU(user);
            //            }
            //            if (choice == 2)
            //            {
            //                Console.WriteLine("ENTER ITEM ID TO UPDATE:");
            //                choice = Convert.ToInt32(Console.ReadLine());
            //                ItemDTO t = new ItemDTO();
            //                item.ChangeItem(t);
            //                Console.WriteLine("PRESS ANYTHING TO RETURN TO MENU");
            //                Console.ReadLine();
            //                MENU(user);
            //            }
            //            else
            //            {
            //                MENU(user);
            //            }
            //        }
            //        if (choice == 2)
            //        {
            //            Console.WriteLine("Enter number to get items sorted \n 1-Price Ascending \n 2-Price Descending \n 3-Newer to Older \n Anything else for older first");
            //            choice = Convert.ToInt32(Console.ReadLine());
            //            item.ShowItemsSorted(choice);
            //            Console.WriteLine("PRESS ANYTHING TO RETURN TO MENU");
            //            Console.ReadLine();
            //            MENU(user);
            //        }
            //        if (choice == 3)
            //        {
            //            ItemDTO t = new ItemDTO();
            //            item.AddItem(t);
            //            Console.WriteLine("ITEM WAS SUCCESFULLY CREATED\n");
            //            Console.WriteLine("PRESS ANYTHING TO RETURN TO MENU");
            //            Console.ReadLine();
            //            MENU(user);

            //        }
            //        else
            //        {
            //            MENU(user);
            //        }
            //    }


            //    if (choice == 2)
            //    {
            //        order.ShowOrders(user);


            //        Console.WriteLine("\n PRESS \n 1-TO FIND ORDER BY ID\n" + "2-TO GET ORDERS SORTED \n ANYTHING ELSE TO RETURN TO MENU\n MY OPTION:");
            //        choice = Convert.ToInt32(Console.ReadLine());
            //        Console.Clear();
            //        if (choice == 1)
            //        {
            //            Console.WriteLine("ENTER ORDER ID TO SHOW:");
            //            int OrderID = Convert.ToInt32(Console.ReadLine());
            //            order.GetOrder(OrderID);
            //            Console.WriteLine("ENTER 1 TO CANCEL ORDER OR 2 TO COMPLETE ORDER OR ANYTHING ELSE TO RETURN TO MENU:");
            //            choice = Convert.ToInt32(Console.ReadLine());
            //            if (choice == 1)
            //            {
            //                order.RemoveOrder(OrderID);
            //                Console.WriteLine($"ORDER {OrderID} has been successfully canceled");

            //                Console.WriteLine("PRESS ANYTHING TO RETURN TO MENU");
            //                Console.ReadLine();
            //                MENU(user);
            //            }
            //            if (choice == 2)
            //            {

            //                ItemDTO t = new ItemDTO();
            //                item.ChangeItem(t);
            //                Console.WriteLine($"Order has been successfully completed");
            //                Console.WriteLine("PRESS ANYTHING TO RETURN TO MENU");
            //                Console.ReadLine();
            //                MENU(user);
            //            }
            //            else
            //            {
            //                MENU(user);
            //            }
            //        }
            //        if (choice == 2)
            //        {
            //            Console.WriteLine("Enter number to get orders sorted \n 1-Older first \n 2- Newer first \n 3-Completed first \n Anything else reccomended");
            //            choice = Convert.ToInt32(Console.ReadLine());
            //            item.ShowItemsSorted(choice);
            //            Console.WriteLine("PRESS ANYTHING TO RETURN TO MENU");
            //            Console.ReadLine();
            //            MENU(user);
            //        }

            //        else
            //        {
            //            MENU(user);
            //        }


            //    }
            //    if (choice == 3)
            //    {
            //        Console.WriteLine("PRESS ANYTHING TO RETURN TO MENU");
            //        Console.ReadLine();
            //        MENU(user);
            //        customer.ShowCustomers();


            //    }
            //    if (choice == 4)
            //    {

            //        Login.Login();


            //    }
            //    else
            //    {
            //        Thread.Sleep(2000);
            //        Console.Clear();
            //    }

            //}






        }
    }
}
