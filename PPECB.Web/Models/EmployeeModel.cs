using Ninject;
using Ninject.Modules;
using PPECB.Repository;
using PPECB.Repository.EF;
//using PPECB.Repository.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace PPECB.Web.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Initial { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        void InitializeView()
        {
            Id = 0;
            Initial = string.Empty;
            Firstname = string.Empty;
            Lastname = string.Empty;
            Email = string.Empty;
            ContactNumber = string.Empty;
            IsActive = false;
            CreateDate = DateTime.MinValue;
            UpdateDate = DateTime.MinValue;
        }

        public void SetViewProperties()
        {
            DependencyFactory factory = new DependencyFactory();
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var employee = kernel.Get<IEmployeeRepository>();
            var emp = employee.GetItemByID(1);
        }
    }

    public class DependencyFactory : NinjectModule
    {
        public override void Load()
        {
             Kernel.Bind<IEmployeeRepository>().To<EmployeeRepository>();
            //Bind<IEmployeeRepository>().To<EmployeeSampleRepository>();
        }
    }
}