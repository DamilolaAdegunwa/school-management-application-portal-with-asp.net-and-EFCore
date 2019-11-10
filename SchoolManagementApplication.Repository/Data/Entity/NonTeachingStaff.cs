using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagementApplication.Core.Enum;
using SchoolManagementApplication.Repository.Data.Entity.ExtendedEntity;

namespace SchoolManagementApplication.Repository.Data.Entity
{
    public class NonTeachingStaff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NonTeachingStaffId{ get; set; }
        public StaffAccount StaffAcount { get; set; }
        public Person Person { get; set; }
        public Medicals Medicals { get; set; }
    }
}
