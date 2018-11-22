using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PPECB.API.Models
{
    public class EmployeeModelDetail
    {
        public int Id { get; set; }
        public string Initial { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}