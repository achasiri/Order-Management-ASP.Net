using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace OrderBasicMVC.Models
{
    public abstract class OrderBaseClass : IOrderBase
    {
        private int orderID;
        public int OrderID   // read-write instance property
        {
            get
            {
                return orderID;
            }
            set
            {
                orderID = value;
            }
        }

        private string customerName;
        public virtual string CustomerName   
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }

        private int accountNumber;
        public virtual int AccountNumber   
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }

        private string orderType;
        public  virtual string OrderType   
        {
            get
            {
                return orderType;
            }
            set
            {
                orderType = value;
            }
        }

        private List<Service> serviceList = new List<Service>();
        public virtual List<Service> ServiceList
        {
            get
            {
                return serviceList;
            }
            set
            {
                serviceList = value;
            }
        }


        private int serviceCountVal;
        public  virtual int ServiceCountVal   
        {
            get
            {
                return serviceCountVal;
            }
            set
            {
                serviceCountVal = value;
            }
        }


        public abstract void AddService();

        public abstract void CancelOrder();

        public abstract void SendToBilling();

        public string displayOrder()
        {
           string orderToString=("Order ID: " + OrderID + "@"+" Account Number: " + AccountNumber + "@"+" Customer Name: " + CustomerName + "@"+" Service Count: " + serviceCount()+"@"+"@");
           return orderToString;
        }

        public int serviceCount()
        {
            return ServiceList.Count;
        }
    }
}