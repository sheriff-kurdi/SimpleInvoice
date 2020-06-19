using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleInvoice.Services
{
    public class InvoiceService
    {



        public static double TotallBeforDiscount(double itemPrice, int itemQuantity)
        {
            return itemPrice * itemQuantity;
        }

        public static double Discount(double TotallBeforDiscount, double discountRate)
        {
            return TotallBeforDiscount * discountRate;
        }

        public static double TotallAfterDiscount(double Discount, double TotallBeforDiscount)
        {
            return TotallBeforDiscount - Discount;
        }

        public static double Tax(double TotallAfterDiscount)
        {
            var tax = 0.15;
            return TotallAfterDiscount * tax;

        }

        public static double Total(double totallafterdiscount, double tax)
        {
            return totallafterdiscount + tax;
        }


    }
}
