using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SchoolManagementApplication.Repository.Data.Entity
{
    [Table("Department",Schema = "dbo")]
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartMentId { get; set; }
        [Required]
        [Column(TypeName = "varchar(1024)")]
        public string DepartmentName { get; set; }
        [Required]
        [Column(TypeName = "varchar(max)")]
        public string DepartmentDescription { get; set; }
        [ForeignKey("FacultyInfo")]
        [Required]
        [Column(TypeName = "int")]
        public int FacultyId { get; set; }
        public virtual Faculty FacultyInfo { get; set; }
    }
}
