using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam_WAD.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public int QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int UnitslnStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReoroderLevel { get; set; }
        public int Discontinued { get; set; }
        public virtual Category Category { get; set; }
    }
}