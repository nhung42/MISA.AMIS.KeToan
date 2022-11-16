using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMIS.Common.Models
{
    public class JobPosition
    {
        /// <summary>
        /// ID
        /// </summary>
        public Guid JobPositionID { get; set; }

        /// <summary>
        /// Mã vị trí
        /// </summary>
        public string JobPositionCode { get; set; }

        /// <summary>
        /// Tên vị trí
        /// </summary>
        public string JobPositionName { get; set; }

        /// <summary>
        /// Thời gian tạo
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Người tạo 
        /// </summary>
        public string CreateBy { get; set; }

        /// <summary>
        /// Thời gian sửa
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Người sửa
        /// </summary>
        public string ModifiedBy { get; set; }
    }
}
