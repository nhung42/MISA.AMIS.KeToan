using MISA.AMIS.Common.Entities;
using MISA.AMIS.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMIS.Common.Interface
{
    public interface IBaseService<MISAEntity>
    {
        /// <summary>
        /// Lấy dữ liệu các bản ghi trong database
        /// </summary>
        /// <returns>Trả về danh sách các đối tượng</returns>
        /// CreatedBy: NhungDT (14/11/2022)
        IEnumerable<MISAEntity> Get();

        /// <summary>
        /// Thêm mới một bản ghi vào database
        /// </summary>
        /// <param name="entity">Đối tượng</param>
        /// <returns>Số bản ghi bị ảnh hưởng</returns>
        ServiceResult Insert(MISAEntity entity);

        /// <summary>
        /// Sửa một bản ghi trong database
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns>Số bản ghi bị ảnh hưởng</returns>
        /// CreatedBy: NhungDT (14/11/2022)
        ServiceResult Update(string entityId, MISAEntity entity);

        /// <summary>
        /// Xóa một bản ghi trong database
        /// </summary>
        /// <param name="entityId">Đối tượng</param>
        /// <returns>Số bản ghi bị ảnh hưởng</returns>
        /// CreatedBy: NhungDT (14/11/2022)
        ServiceResult Delete(string entityId);
        IEnumerable<Employee> Paging(Page page);
    }
}
