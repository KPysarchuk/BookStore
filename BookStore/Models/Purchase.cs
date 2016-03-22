using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Purchase
    {
        // Purchase ID
        public int PurchaseId { get; set; }
        // Buyer Name
        public string Person { get; set; }
        // Buyer Address
        public string Address { get; set; }
        // Book ID
        public int BookId { get; set; }
        // Purchase Date
        public DateTime Date { get; set; }
    }
}