using PPECB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPECB.Repository.Sample
{
    public class EmployeeSampleRepository : IEmployeeRepository
    {
        public bool AddItem(EmployeeDTO item)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<EmployeeDTO> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public EmployeeDTO GetItemByID(int Id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateItem(EmployeeDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
