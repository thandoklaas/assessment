using PPECB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPECB.Repository.EF
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public bool AddItem(EmployeeDTO item)
        {
            var success = false;

            using (TechTestDBEntities context = new TechTestDBEntities())
            {
                Employee data = new Employee();

                context.Employees.Add(data);

                data.Initial = item.Initial;
                data.Firstname = item.Firstname;
                data.Lastname = item.Lastname;
                data.Email = item.Email;
                data.ContactNumber = item.ContactNumber;
                data.IsActive = item.IsActive;
                data.CreateDate = item.CreateDate;
                data.UpdateDate = item.UpdateDate;

                context.SaveChanges();

                item.Id = data.Id;

                success = true;
            }
            return success;
        }

        public bool DeleteItem(int id)
        {
            //Soft deletes only for this assement.
            bool success = false;

            using (TechTestDBEntities context = new TechTestDBEntities())
            {
                Employee employee = context.Employees.FirstOrDefault(i => i.Id == id);

                if (employee != null)
                {
                    employee.IsActive = false;
                    context.SaveChanges();

                    success = true;
                }
            }
            return success;
        }

        public IQueryable<EmployeeDTO> GetAllItems()
        {

            IQueryable<EmployeeDTO> employees = null;

            using (TechTestDBEntities context = new TechTestDBEntities())
            {
                List<Employee> data = (from c in context.Employees
                                       select c).ToList();

                employees= data.ConvertAll(x => new EmployeeDTO
                {
                    Id = x.Id,
                    Initial = x.Initial,
                    Firstname = x.Firstname,
                    Lastname = x.Lastname,
                    Email = x.Email,
                    ContactNumber = x.ContactNumber,
                    IsActive = x.IsActive.GetValueOrDefault(),
                    CreateDate = x.CreateDate.GetValueOrDefault(),
                    UpdateDate = x.UpdateDate.GetValueOrDefault()
                }).AsQueryable();

            }

            return employees;
        }

        public EmployeeDTO GetItemByID(int Id)
        {
            EmployeeDTO result = new EmployeeDTO();

            using (TechTestDBEntities context = new TechTestDBEntities())
            {
                Employee employee = context.Employees.FirstOrDefault(i => i.Id == Id);

                if (employee != null)
                {
                    result.Id = employee.Id;
                    result.Initial = employee.Initial;
                    result.Firstname = employee.Firstname;
                    result.Lastname = employee.Lastname;
                    result.Email = employee.Email;
                    result.ContactNumber = employee.ContactNumber;
                    result.IsActive = employee.IsActive.GetValueOrDefault(); ;
                    result.CreateDate = employee.CreateDate.GetValueOrDefault();
                    result.UpdateDate = employee.UpdateDate.GetValueOrDefault();
                }
            }
            return result;
        }

        public bool UpdateItem(EmployeeDTO item)
        {
            bool success = false;
          
            using (TechTestDBEntities context = new TechTestDBEntities())
            {
                Employee employee = context.Employees.FirstOrDefault(i => i.Id == item.Id);

                if (employee != null)
                {
                    employee.Id = item.Id;
                    employee.Initial = item.Initial;
                    employee.Firstname = item.Firstname;
                    employee.Lastname = item.Lastname;
                    employee.Email = item.Email;
                    employee.ContactNumber = item.ContactNumber;
                    employee.IsActive = item.IsActive;
                    employee.CreateDate = item.CreateDate;
                    employee.UpdateDate = item.UpdateDate;

                    context.SaveChanges();

                    success = true;
                }
            }
            return success;
        }
    }
}
