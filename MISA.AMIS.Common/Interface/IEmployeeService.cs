using MISA.AMIS.Common.Entities;
using MISA.AMIS.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMIS.Common.Interface
{
    public class IEmployeeService: IBaseService<Employee>
    {
        public ServiceResult Delete(string entityId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> Get()
        {
            throw new NotImplementedException();
        }

        public ServiceResult Insert(Employee entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> Paging(Page page)
        {
            throw new NotImplementedException();
        }

        public ServiceResult Update(string entityId, Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
