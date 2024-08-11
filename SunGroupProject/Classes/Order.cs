using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SunGroupProject.Classes
{
    public class Order
    {
        public delegate void OrderDelegate(Order order);
        public event OrderDelegate OrderEvent;

        public delegate double ShowTotalDelegate(double prodPrice, double prodQnt);
        public string ProductName { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public void OrderMethod(Order order)
        {
            OrderEvent?.Invoke(order);
        }

        public double ShowTotalMethd(double prodPrice, double prodQnt, ShowTotalDelegate dlg)
        {
            return dlg(prodPrice, prodQnt);
        }

        //public double CalcTotal(double prodPrice, double prodQnt)
        //{
        //    return prodPrice * prodQnt; ;
        //}
    }
}
