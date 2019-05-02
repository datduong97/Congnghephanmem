using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Customer.Data
{
    public  class WebDbContext:DbContext
    {
        public WebDbContext (DbContextOptions<WebDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Table>(model =>
            {
                model.ToTable("Table","dbo");
            });
            modelBuilder.Entity<Food>(model =>
            {
                model.ToTable("Food", "dbo");
            });
        }
    }
}
