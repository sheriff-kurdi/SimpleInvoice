using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleInvoice.Models
{
    public class Invoice : InvoiceVM
    {
        public double Total { get; set; }
        public double Taxes { get; set; }
        public double Net { get; set; }
    }
}
