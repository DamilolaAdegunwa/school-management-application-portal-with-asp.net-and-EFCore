using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagementApplication.Core.Enum;
namespace SchoolManagementApplication.Repository.Data.Entity.ExtendedEntity
{
    public class StaffAccount
    {
        [Key]
        public int StaffAccountId { get; set; }
        #region Lecturer properties
        public Lecturer Lecturer { get; set; }
        public int LecturerId { get; set; }
        #endregion
        #region NonTeachingStaff field
        public NonTeachingStaff NonTeachingStaff { get; set; }
        public int NonTeachingStaffId { get; set; }
        #endregion
    }
}
