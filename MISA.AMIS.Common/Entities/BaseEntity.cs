using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMIS.Common.Entities
{/// <summary>
 /// Attribute xác định thông tin bắt buộc phải nhập
 /// </summary>
 /// CreadtedBy: NhungDT (14/11/2022)
    [AttributeUsage(AttributeTargets.Property)]
    public class Required : Attribute
    {
        #region Field
        public string propertyName;
        public string errorMsg;
        #endregion

        #region Constructor
        public Required(string propertyName, string errorMsg)
        {
            this.propertyName = propertyName;
            this.errorMsg = errorMsg;
        }
        #endregion
    }

    /// <summary>
    /// Attribute xác định thông tin bị trùng
    /// </summary>
    /// CreatedBy: NQDat (07/02/2021)
    [AttributeUsage(AttributeTargets.Property)]
    public class Duplicated : Attribute
    {
        #region Field
        public string propertyName;
        public string errorMsg;
        #endregion

        #region Constructor
        public Duplicated(string propertyName, string errorMsg)
        {
            this.propertyName = propertyName;
            this.errorMsg = errorMsg;
        }
        #endregion
    }
}
