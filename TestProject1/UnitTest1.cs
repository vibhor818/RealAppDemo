using Microsoft.AspNetCore.Mvc;
using RealAppDemo.Controllers;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Index()
        {
            var controller = new EmpController(new FakeEmployeeRepository());
            var result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}