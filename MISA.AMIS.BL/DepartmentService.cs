using MISA.AMIS.Common.Interface;
using MISA.AMIS.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMIS.BL
{
    public class DepartmentService : BaseService<Department>,IDepartmentService
    {
        public DepartmentService(IDbContext<Department> dbconnection) : base(dbconnection)
        {
        }
    }
}
