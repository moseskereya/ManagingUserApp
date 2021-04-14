using ManagingApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagingApp.Data
{
    public class ManagingContext : DbContext
    {
        public ManagingContext(DbContextOptions<ManagingContext> options) :base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}
