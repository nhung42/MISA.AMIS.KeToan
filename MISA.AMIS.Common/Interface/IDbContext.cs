using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMIS.Common.Interface
{
    public interface IDbContext<MISAEntity>
    {
        /// <summary>
        /// Lấy dữ liệu từ cơ sở dữ liệu
        /// </summary>
        /// <returns>Danh sách các bản ghi</returns>
        /// CreatedBy:NhungDT (14/11/2022)
        IEnumerable<MISAEntity> Get(string sqlCommand, DynamicParameters parameters, CommandType commandType);

        /// <summary>
        /// Thực thi một câu lệnh sql
        /// </summary>
        /// <returns>Số bản ghi bị ảnh hưởng</returns>
        /// CreatedBy: NhungDT (14/11/2022)
        int ExcuteNonQuery(string sqlCommand, DynamicParameters parameters, CommandType commandType);
    }
}
