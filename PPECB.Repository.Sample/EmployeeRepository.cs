using System;
using System.Linq;
using PPECB.DTO;

namespace PPECB.Repository.Sample
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public bool AddItem(EmployeeDTO item)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(EmployeeDTO item)
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
