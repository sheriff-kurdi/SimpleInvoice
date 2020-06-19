using System;
using System.Collections.Generic;
using System.Text;
using SimpleInvoice.Models;
using Microsoft.EntityFrameworkCore;


namespace SimpleInvoice.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Invoice> Invoices { get; set; }

    }
}
