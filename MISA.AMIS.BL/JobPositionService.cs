using MISA.AMIS.Common.Interface;
using MISA.AMIS.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMIS.BL
{
    public class JobPositionService : BaseService<JobPositionService>
    {
        public JobPositionService(IDbContext<JobPositionService> dbconnection) : base(dbconnection)
        {
        }
    }
}
