using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderBasicMVC.Models
{
    public class ParamedOrder:OrderBaseClass
    {
        public override  void AddService()
        {
            Service ser = new Service();
            ServiceList.Add(ser);
            Console.WriteLine("Add Service in Paramed Report Order");
        }

        public override  void CancelOrder()
        {
            Console.WriteLine("Cancel Paramed Order");
        }

        public override void SendToBilling()
        {
            Console.WriteLine("Send Paramed Order to Billing");
        }
      
    }
}