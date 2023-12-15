using RealAppDemo.DataContexts;
using RealAppDemo.DataInterfaces;
using RealAppDemo.Models;

namespace RealAppDemo.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        VBContext context;
        public EmployeeRepository(VBContext _con)
        {
            context = _con;
        }
        public IEnumerable<Customer> GetCustomers()
        {
            return context.Customer.ToList();
        }
    }
}
