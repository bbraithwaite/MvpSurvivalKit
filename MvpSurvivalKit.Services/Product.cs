using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvpSurvivalKit.Services
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public IList<string> CustomerComments { get; set; }
    }
}
