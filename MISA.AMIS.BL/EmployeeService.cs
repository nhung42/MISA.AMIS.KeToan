using Dapper;
using MISA.AMIS.Common.Interface;
using MISA.AMIS.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMIS.BL
{
    public class EmployeeService : BaseService< Employee >, IEmployeeService
    {
        public EmployeeService(IDbContext<Employee> dbconnection) : base(dbconnection)
        {
        }

        public IEnumerable<Employee> Paging(Page page)
        {
            var sqlCommand = "Proc_employee_GetPaging";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@limitRow", page.limit);
            parameters.Add("@offsetRow", page.offset);
            return (IEnumerable<Employee>)dbconnection.Get(sqlCommand, parameters, System.Data.CommandType.StoredProcedure);
        }
    }
}
