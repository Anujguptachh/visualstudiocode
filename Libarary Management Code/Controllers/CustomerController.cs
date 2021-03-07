using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Libarary_Management_Code.Models;
using System.Data.Entity;
namespace Libarary_Management_Code.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        { using (ProjectsEntities obj =new ProjectsEntities())
            return View(obj.customers.ToList());
        }

        [HttpGet]
        public ActionResult IndexSearch()
        {
            using (ProjectsEntities obj = new ProjectsEntities())
            {
                return View(obj.customers.ToList());
                //var cust = obj.customers.Include(x => x.Address);
                //return View(cust.ToList());
            }

        }
        [HttpPost]
        public ActionResult IndexSearch(string searching)
        {
            using (ProjectsEntities obj = new ProjectsEntities())
            {/* var cust = obj.customers.ToList().Where(x => x.Name.StartsWith(searching));*/
                return View(obj.customers.ToList().Where(x => x.Name.StartsWith(searching)));
            }

        }

        public ActionResult Paymentleft()
        {
            using (ProjectsEntities1 obj = new ProjectsEntities1())
                return View(obj.PENDINGPAYMENTs.ToList());
        }
        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            using (ProjectsEntities obj = new ProjectsEntities())
            {
                return View(obj.customers.Where(x => x.ID == id).FirstOrDefault());


            }

            
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            var list1 = new List<string>() { "M", "F" };
            ViewBag.list1 = list1;
            var list2 = new List<int>() { 4,6,12 };
            ViewBag.list2 = list2;
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(customer Customer)
        {
            var list1 = new List<string>() { "M", "F" };
            ViewBag.list1 = list1;
            var list2 = new List<int>() { 4,6,12};
            ViewBag.list2 = list2;
            try
            {
                using (ProjectsEntities obj = new ProjectsEntities())
                {
                    obj.customers.Add(Customer);
                    obj.SaveChanges();
                    ViewData["Message"] = "The ID generated for " + Customer.Name + " is: " + Customer.ID;
               
                    
                }
                
                return View(Customer);
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            using (ProjectsEntities obj = new ProjectsEntities())
            {
                return View(obj.customers.Where(x => x.ID == id).FirstOrDefault());


            }
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, customer Customer)
        {
            try
            {
                using (ProjectsEntities obj = new ProjectsEntities())
                {
                    obj.Entry(Customer).State = EntityState.Modified;
                    obj.SaveChanges();


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
            using (ProjectsEntities obj = new ProjectsEntities())
            {
                return View(obj.customers.Where(x => x.ID == id).FirstOrDefault());


            }
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, customer Customer)
        {
            try
            {
                using (ProjectsEntities obj = new ProjectsEntities())
                {

                    Customer = obj.customers.Where(x => x.ID == id).FirstOrDefault();
                    obj.customers.Remove(Customer);
                    obj.SaveChanges();

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
