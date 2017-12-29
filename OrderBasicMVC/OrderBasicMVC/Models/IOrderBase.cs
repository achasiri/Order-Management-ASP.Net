using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBasicMVC.Models
{
    interface IOrderBase
    {
        int OrderID {get; set;}
		string CustomerName {get;set;}
        int AccountNumber { get; set; }
		string OrderType {get;set;}
	    List<Service>  ServiceList {get; set;}
       
        void AddService();
        void CancelOrder();
        void SendToBilling();

    }
}
