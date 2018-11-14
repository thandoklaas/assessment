using Ninject;
using PPECB.DTO;
using PPECB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace PPECB.API.Models
{
    public class EmployeeModel
    {
        private readonly StandardKernel kernel = null;
        private readonly IEmployeeRepository employeeRepository = null;

        public EmployeeModel()
        {
            kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            employeeRepository = kernel.Get<IEmployeeRepository>();
        }
        public static EmployeeModelDetail GetViewProperties(int id)
        {
            EmployeeModel model = new EmployeeModel();

            var employee = model.employeeRepository.GetItemByID(id);

            return new EmployeeModelDetail()
            {
                Id = employee.Id,
                Initial = employee.Initial,
                Firstname = employee.Firstname,
                Lastname = employee.Lastname,
                Email = employee.Email,
                ContactNumber = employee.ContactNumber,
                IsActive = employee.IsActive,
                CreateDate = employee.CreateDate,
                UpdateDate = employee.UpdateDate
            };
        }
        public static bool AddEmployee(EmployeeModelDetail employee)
        {
            EmployeeModel model = new EmployeeModel();

            return model.employeeRepository.AddItem(new EmployeeDTO
            {
                Id = employee.Id,
                Initial = employee.Initial,
                Firstname = employee.Firstname,
                Lastname = employee.Lastname,
                Email = employee.Email,
                ContactNumber = employee.ContactNumber,
                IsActive = employee.IsActive,
                CreateDate = employee.CreateDate,
                UpdateDate = employee.UpdateDate
            });
        }
        public static bool UpdateEmployee(EmployeeModelDetail employee)
        {
            EmployeeModel model = new EmployeeModel();

            return model.employeeRepository.UpdateItem(new EmployeeDTO
            {
                Id = employee.Id,
                Initial = employee.Initial,
                Firstname = employee.Firstname,
                Lastname = employee.Lastname,
                Email = employee.Email,
                ContactNumber = employee.ContactNumber,
                IsActive = employee.IsActive,
                CreateDate = employee.CreateDate,
                UpdateDate = employee.UpdateDate
            });
        }
        public static bool DeleteEmployee(int employeeId)
        {
            EmployeeModel model = new EmployeeModel();

            return model.employeeRepository.DeleteItem(employeeId);
        }     
        public static IEnumerable<EmployeeModelDetail> GetEmployeeList()
        {

            EmployeeModel employee = new EmployeeModel();

            return employee.employeeRepository.GetAllItems().ToList().ConvertAll(x => new EmployeeModelDetail
            {
                Id = x.Id,
                Initial = x.Initial,
                Firstname = x.Firstname,
                Lastname = x.Lastname,
                Email = x.Email,
                ContactNumber = x.ContactNumber,
                IsActive = x.IsActive,
                CreateDate = x.CreateDate,
                UpdateDate = x.UpdateDate
            }).AsEnumerable();

        }

    }
}