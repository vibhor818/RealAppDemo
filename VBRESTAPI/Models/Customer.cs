using Microsoft.EntityFrameworkCore;

namespace VBRESTAPI.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
    }
    public class VBContext : DbContext
    {
        public VBContext(DbContextOptions<VBContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //optionsBuilder.UseSqlServer(@"data source=(localdb)\mssqllocaldb;database=vbcustomerorderdb;trusted_connection=true");
        }
        public DbSet<Customer> Customer { get; set; }
    }
}
