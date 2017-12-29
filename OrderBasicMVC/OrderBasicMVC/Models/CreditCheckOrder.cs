using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderBasicMVC.Models
{
    public class CreditCheckOrder : OrderBaseClass
    {
       
        public override  void AddService()
        {
            Service ser = new Service();
            ServiceList.Add(ser);
            Console.WriteLine("Add Service in Credit Check Order");
        }

        public override  void CancelOrder()
        {
            Console.WriteLine("Cancel Credit Check Order");
        }

        public override void SendToBilling()
        {
            Console.WriteLine("Send Credit Check Order to Billing");
        }

      
    }
}