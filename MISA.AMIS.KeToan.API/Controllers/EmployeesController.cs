using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.AMIS.Common.Interface;
using MISA.AMIS.Common.Models;
using MISA.AMIS.KeToan.Api.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.AMIS.Api.Controllers
{
    public class EmployeesController : BaseController<Employee>
    {
        IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService overtimeFormService) : base(overtimeFormService)
        {
            _employeeService = overtimeFormService;
        }

        [HttpGet("/api/v1/Employees/fillter")]
        public IEnumerable<Employee> Paging(Page page)
        {
            return _employeeService.Paging(page);
        }
    }
}
