﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMIS.Common.Entities
{
    /// <summary>
    /// Kết quả service trả về
    /// </summary>
    /// CreatedBy: NhungDT(14/11/2022)
    public class ServiceResult
    {
        #region Property
        /// <summary>
        /// Thông báo cho lập trình viên
        /// </summary>
        public string devMsg { get; set; }

        /// <summary>
        /// Thông báo cho khách hàng
        /// </summary>
        public string userMsg { get; set; }


        /// <summary>
        /// Mã trả về
        /// </summary>
        public int MISACode { get; set; }

        /// <summary>
        /// Dữ liệu trả về
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// Thông tin chi tiết
        /// </summary>
        public string moreInfo { get; set; }
        #endregion
    }
}
