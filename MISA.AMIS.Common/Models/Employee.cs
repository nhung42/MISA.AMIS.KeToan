using MISA.AMIS.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMIS.Common.Models
{
    public class Employee
    {
        /// <summary>
        /// ID
        /// </summary>
        public Guid EmployeeID { get; set; }

        /// <summary>
        /// Mã nhân viên
        /// </summary>
        public string EmployeeCode { get; set; }

        /// <summary>
        /// Tên nhân viên
        /// </summary>
        public string EmployeeName { get; set; }

        /// <summary>
        /// Giới tính
        /// </summary>
        public MISAGender Gender { get; set; }

        public Employee(MISAGender gender)
        {
            Gender = gender;
        }

        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        ///  Mã đơn vị
        /// </summary>
        public Guid DepartmentID { get; set; }

        /// <summary>
        /// Tên đơn vị
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        ///  Mã vị trí
        /// </summary>
        public Guid JobPositionID { get; set; }

        /// <summary>
        /// Tên vị trí
        /// </summary>
        public string JobPositonName { get; set; }

        ///<summary>
        ///Số chứng minh nhân dân
        ///</summary>
        public string IdentityNumber { get; set; }

        /// <summary>
        /// Ngày cấp
        /// </summary>
        public DateTime IdentityIssueDate { get; set; }

        ///<summary>
        ///Nơi cấp
        ///</summary>
        public string IdentityIssuePlace { get; set; }

        ///<summary>
        ///Số điện thoại
        ///</summary>
        public string PhoneNumber { get; set; }

        ///<summary>
        ///Số điện thoại cố định
        ///</summary>
        public string Phone { get; set; }

        ///<summary>
        ///Email
        ///</summary>
        public string Email { get; set; }

        ///<summary>
        ///Số tài khoản
        ///</summary>
        public string BankAccount { get; set; }

        ///<summary>
        ///Tên ngân hàng
        ///</summary>
        public string BankName { get; set; }

        ///<summary>
        ///Chi nhánh ngân hàng
        ///</summary>
        public string BankBranch { get; set; }

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
