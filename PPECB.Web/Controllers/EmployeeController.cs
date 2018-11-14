using Ninject;
using PPECB.Repository;
using PPECB.Web.Models;
using System.Reflection;
using System.Web.Mvc;

namespace PPECB.Web.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {


            EmployeeModel model = new EmployeeModel();
            model.SetViewProperties();
            //var t = employee.GetAllItems();// GetItemByID(1);
            //var employeeSample = kernel.Get<IEmployeeRepository>();
            return View(model);
        }
    }
}