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
    public class DepartmentsController : BaseController<Department>
    {
        public DepartmentsController(IDepartmentService dbConection) : base(dbConection)
        {

        }
    }
}
