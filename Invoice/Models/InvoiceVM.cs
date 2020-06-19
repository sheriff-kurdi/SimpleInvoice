using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleInvoice.Models
{
    public class InvoiceVM
    {
        public string Id { get; set; }
        public string Date { get; set; }
        [Required]
        public string ItemName { get; set; }
        [Required]
        public string UnitName { get; set; }
        [Required]
        public double ItemPrice { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double Discount { get; set; }


   

    }
}
