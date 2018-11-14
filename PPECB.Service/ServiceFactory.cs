using Ninject.Modules;
using PPECB.Repository;
using PPECB.Repository.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPECB.Service
{
    public class ServiceFactory : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IEmployeeRepository>().To<EmployeeRepository>();
            //Bind<IEmployeeRepository>().To<EmployeeSampleRepository>();
        }
    }

}
