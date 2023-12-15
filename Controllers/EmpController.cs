using Microsoft.AspNetCore.Mvc;
using RealAppDemo.DataInterfaces;
using RealAppDemo.Repositories;

namespace RealAppDemo.Controllers
{
    //http://vb.com/Emp/Index
    public class EmpController : Controller
    {
        IEmployeeRepository _repos;
        public EmpController(IEmployeeRepository repo)
        {
            _repos = repo;
        }
        public IActionResult Index()
        {
            return View(_repos.GetCustomers());
        }
    }
}
