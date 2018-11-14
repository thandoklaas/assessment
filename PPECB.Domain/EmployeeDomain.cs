using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPECB.Domain
{
    public class EmployeeDomain
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

        private EmployeeDomain()
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
        //prevents direct creation.
        public static EmployeeDomain NewEmployeeDomain()
        {
            return new EmployeeDomain();
        }

        public static IEnumerable<EmployeeDomain> GetEmployees()
        {
            return null;
        }
    }
}
