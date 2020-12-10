using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;
using System.Data.Entity;

namespace MVC.Controllers
{
    public class Current_orderController : Controller
    {
        // GET: Current_order
        public ActionResult Index()
        {
            using (DBM db = new DBM())
            {
                return View(db.Current_order.ToList());
            }
        }

        // GET: Current_order/Details/5
        public ActionResult Details(int id)
        {
            using (DBM db = new DBM())
            {
                return View(db.Current_order.Where(x => x.O_M_id == id).FirstOrDefault());
            }
        }

        // GET: Current_order/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Current_order/Create
        [HttpPost]
        public ActionResult Create(Current_order c_o)
        {
            try
            {
                // TODO: Add insert logic here
                using (DBM db = new DBM())
                {
                    db.Current_order.Add(c_o);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Current_order/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBM db = new DBM())
            {
                return View(db.Current_order.Where(x => x.O_M_id == id).FirstOrDefault());
            }
        }

        // POST: Current_order/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Order_Manager o_m)
        {
            try
            {
                // TODO: Add update logic here
                using (DBM db = new DBM())
                {
                    db.Entry(o_m).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Current_order/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBM db = new DBM())
            {
                return View(db.Current_order.Where(x => x.O_M_id == id).FirstOrDefault());
            }
        }

        // POST: Current_order/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Current_order o_m)
        {
            try
            {
                // TODO: Add delete logic here
                using (DBM db = new DBM())
                {
                    return View(db.Current_order.Where(x => x.O_M_id == id).FirstOrDefault());
                    db.Current_order.SaveChanges();
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
