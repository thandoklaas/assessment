
using Ninject.Modules;
using PPECB.Repository.EF;
using PPECB.Repository.Sample;

namespace PPECB.Repository.Factory
{
    public class DependencyFactory : NinjectModule
    {
        public override void Load()
        {
           // Kernel.Bind<IEmployeeRepository>().To<EmployeeRepository>();
            //Bind<IEmployeeRepository>().To<EmployeeSampleRepository>();
        }
    }
}
