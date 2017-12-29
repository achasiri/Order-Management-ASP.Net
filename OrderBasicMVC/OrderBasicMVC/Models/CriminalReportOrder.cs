using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderBasicMVC.Models
{
    public class CriminalReportOrder:OrderBaseClass
    {
        public override  void AddService()
        {
            Service ser = new Service();
            ServiceList.Add(ser);
            Console.WriteLine("Add Service in Criminal Report Order");
        }

        public override  void CancelOrder()
        {
            Console.WriteLine("Cancel Criminal Report Order");
        }

        public override  void SendToBilling()
        {
            Console.WriteLine("Send Criminal Report Order to Billing");
        }

      
    }
}