using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleInvoice.Models;
using Microsoft.AspNetCore.Mvc;
using SimpleInvoice.Data;

namespace SimpleInvoice.Controllers
{
    public class InvoicesController : Controller
    {
        private readonly ApplicationDbContext db;

        public InvoicesController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InvoiceResults(InvoiceVM invoice)
        {

            if (ModelState.IsValid)
            {

                var totalCostBeforDiscount = Services.InvoiceService.TotallBeforDiscount(invoice.ItemPrice, invoice.Quantity);
                var discount = Services.InvoiceService.Discount(totalCostBeforDiscount, invoice.Discount);
                var totalCostAfterDiscount = Services.InvoiceService.TotallAfterDiscount(discount, totalCostBeforDiscount);
                var tax = Services.InvoiceService.Tax(totalCostAfterDiscount);
                var total = Services.InvoiceService.Total(totalCostAfterDiscount, tax);

                Invoice invoiceResults = new Invoice
                {
                    Net = totalCostBeforDiscount,
                    Taxes = tax,
                    Total = total,

                    Date = DateTime.Now.ToString(),
                    Discount = invoice.Discount,
                    Id = invoice.Id,
                    ItemName = invoice.ItemName,
                    ItemPrice = invoice.ItemPrice,
                    Quantity = invoice.Quantity,
                    UnitName = invoice.UnitName
                };

                return View(invoiceResults);

            }

            return RedirectToAction("Index", invoice);

        }

        [HttpPost]
        public async Task<IActionResult> InvoiceConfirmation(Invoice invoiceResults)
        {
            await db.Invoices.AddAsync(invoiceResults);
            await db.SaveChangesAsync();
            return View(invoiceResults);
        }

        [HttpGet]
        public  IActionResult GetAllInvoices()
        {
            
            return View(db.Invoices.ToList());
        }
    }
}