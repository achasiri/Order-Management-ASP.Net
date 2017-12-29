using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderBasicMVC.Models;
namespace OrderBasicMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        List<CreditCheckOrder> orderList = new List<CreditCheckOrder>();
        public ActionResult Index()
        {
            return View();
        }


        //on click
        public ActionResult GetRecords()
        {
            CreditCheckOrder cOr = new CreditCheckOrder();
            {
                cOr.OrderID = 101;
                cOr.CustomerName = "TestCustomer#1";
                cOr.AccountNumber = 000000000;
                Service servi1 = new Service();
                Service servi2 = new Service();
                cOr.AddService();
                cOr.AddService();
            }

            CreditCheckOrder cOr1 = new CreditCheckOrder();
            {
                cOr1.OrderID = 102;
                cOr1.CustomerName = "TestCustomer#3";
                cOr1.AccountNumber = 000000000;
                Service servi1 = new Service();
                Service servi2 = new Service();
                Service servi3 = new Service();
                cOr1.AddService();
                cOr1.AddService();
                cOr1.AddService();
            }
            CreditCheckOrder cOr2 = new CreditCheckOrder();
            {
                cOr2.OrderID = 103;
                cOr2.CustomerName = "TestCustomer#3";
                cOr2.AccountNumber = 000000000;
                Service servi1 = new Service();
                cOr2.AddService();

            }


            orderList.Add(cOr);
            orderList.Add(cOr1);
            orderList.Add(cOr2);
            string orderTostring="";
            foreach(CreditCheckOrder objectItem in orderList)
            {
                orderTostring = orderTostring+objectItem.displayOrder();

                orderTostring = orderTostring.Replace("@", "<br/>" + System.Environment.NewLine);
            
            }
            return Content(orderTostring, "text/plain");
           // return Content("", "text/plain");
           
             
        }


    }
}
