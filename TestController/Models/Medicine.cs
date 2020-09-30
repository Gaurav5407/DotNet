using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestController.Models
{
    public class Medicine
    {
     
        public static List<Medicine> lst { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}