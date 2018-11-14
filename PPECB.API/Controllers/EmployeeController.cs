using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using PPECB.API.Models;
using System.Net;

namespace PPECB.API.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET: Employee
        public IHttpActionResult GetEmployee(int id)
        {
            var employee = GetEmployees().FirstOrDefault(x => x.Id == id);

            return Ok(employee ?? new EmployeeModelDetail());
        }

        public IEnumerable<EmployeeModelDetail> GetEmployees()
        {
            return EmployeeModel.GetEmployeeList();
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult AddEmployee(EmployeeModelDetail model)
        {
            if(EmployeeModel.AddEmployee(model))
                return Ok(HttpStatusCode.OK);

            return Ok(HttpStatusCode.NotModified);
        }


        [System.Web.Http.HttpPost]
        public IHttpActionResult DeleteEmployee(int id)
        {
            if (EmployeeModel.DeleteEmployee(id))
                return Ok(HttpStatusCode.OK);

            return Ok(HttpStatusCode.NotModified);
        }

        [System.Web.Http.HttpPut]
        public IHttpActionResult UpdateEmployee(EmployeeModelDetail model)
        {
            if (EmployeeModel.UpdateEmployee(model))
                return Ok(HttpStatusCode.OK);

            return Ok(HttpStatusCode.NotModified);
        }
    }
}