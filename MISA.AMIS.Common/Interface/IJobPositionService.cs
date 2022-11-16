using MISA.AMIS.Common.Entities;
using MISA.AMIS.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMIS.Common.Interface
{
    public class IJobPositionService : IBaseService<JobPosition>
    {
        public ServiceResult Delete(string entityId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JobPosition> Get()
        {
            throw new NotImplementedException();
        }

        public ServiceResult Insert(JobPosition entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> Paging(Page page)
        {
            throw new NotImplementedException();
        }

        public ServiceResult Update(string entityId, JobPosition entity)
        {
            throw new NotImplementedException();
        }
    }
}
