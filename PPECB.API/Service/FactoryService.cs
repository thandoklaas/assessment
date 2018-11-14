using Ninject.Modules;
using PPECB.Repository;
using PPECB.Repository.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PPECB.API.Service
{
    public class FactoryService : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IEmployeeRepository>().To<EmployeeRepository>();
            //Bind<IEmployeeRepository>().To<EmployeeSampleRepository>();
        }
    }
}