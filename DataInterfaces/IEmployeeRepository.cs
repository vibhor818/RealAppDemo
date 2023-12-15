using RealAppDemo.Models;

namespace RealAppDemo.DataInterfaces
{
    public interface IEmployeeRepository
    {
       IEnumerable<Customer> GetCustomers();
    }
}
