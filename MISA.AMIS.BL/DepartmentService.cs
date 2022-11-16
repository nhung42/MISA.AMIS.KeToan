using MISA.AMIS.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMIS.BL
{
    public class DepartmentService : BaseService<DepartmentService>
    {
        public DepartmentService(IDbContext<DepartmentService> dbconnection) : base(dbconnection)
        {
        }
    }
}
