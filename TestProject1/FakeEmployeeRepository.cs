using RealAppDemo.DataInterfaces;
using RealAppDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class FakeEmployeeRepository : IEmployeeRepository
    {
        List<Customer> liCust;
        public FakeEmployeeRepository()
        {
            liCust = new List<Customer>();
            liCust.Add(new Customer { CustomerId = 1, CustomerName = "aaaa", CustomerAddress = "123abc" });
            liCust.Add(new Customer { CustomerId = 2, CustomerName = "bbbb", CustomerAddress = "124abc" });
            liCust.Add(new Customer { CustomerId = 3, CustomerName = "cccc", CustomerAddress = "125abc" });
        }
        public IEnumerable<Customer> GetCustomers()
        {
            return liCust;
        }
    }
}
