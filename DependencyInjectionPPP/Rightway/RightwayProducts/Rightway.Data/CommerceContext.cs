using Microsoft.EntityFrameworkCore;
using Rightway.ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rightway.Data
{
    public class CommerceContext : DbContext
    {
        private readonly string connectionString;

        public CommerceContext(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("connectionString should not be empty.", connectionString);

            this.connectionString = connectionString;
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}
