using Microsoft.EntityFrameworkCore;
using RealAppDemo.Models;

namespace RealAppDemo.DataContexts
{
    public class VBContext:DbContext
    {
        public VBContext(DbContextOptions<VBContext> options):base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            //optionsBuilder.UseSqlServer(@"data source=(localdb)\mssqllocaldb;database=vbcustomerorderdb;trusted_connection=true");
        }
        public DbSet<Customer>  Customer { get; set; }
    }
}
