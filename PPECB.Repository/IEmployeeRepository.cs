using PPECB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PPECB.Repository
{
    public interface IEmployeeRepository
    {
        bool AddItem(EmployeeDTO item);

        EmployeeDTO GetItemByID(int Id);

        IQueryable<EmployeeDTO> GetAllItems();

        bool UpdateItem(EmployeeDTO item);

        bool DeleteItem(int id);
    }
}

