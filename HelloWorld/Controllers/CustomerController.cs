using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Load()
        {
            Customer obj =new Customer { CustomerCode = "1001", CustomerName = "Jenson" };
            return View("Customer", obj);
        }

        public ActionResult Enter()
        {
            return View("EnterCustomer");
        }

        public ActionResult Submit(Customer obj)
        {
            //Because the name of the text input fields match the Customer class property names, you can pass the customer obj to the action method
            //Customer obj = new Customer();
            //obj.CustomerCode = Request.Form["CustomerCode"];
            //obj.CustomerName = Request.Form["CustomerName"];
            return View("Customer", obj);
        }
    }
}