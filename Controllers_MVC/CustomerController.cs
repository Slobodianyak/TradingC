using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;
using System.Data.Entity;

namespace MVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            using (DBM db = new DBM())
            {
                return View(db.Customer.Tolist());
            }
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            using(DBM db = new DBM())
            {
                return View(db.Customer.Where(x => x.Customer_id == id).FirstOrDefault());
            }
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                // TODO: Add insert logic here
                using (DBM db = new DBM())
                {
                    db.Cusomers.Add(customer);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBM db = new DBM())
            {
                return View(db.Customer.Where(x => x.Customer_id == id).FirstOrDefault());
            }
            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                // TODO: Add update logic here
                using(DBM db = new DBM())
                {
                    db.Entry(customer).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBM db = new DBM())
            {
                return View(db.Customer.Where(x => x.Customer_id == id).FirstOrDefault());
            }
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Customer customer)
        {
            try
            {
                // TODO: Add delete logic here
                using (DBM db = new DBM())
                {
                    return View(db.Customer.Where(x => x.Customer_id == id).FirstOrDefault());
                    db.Customer.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
