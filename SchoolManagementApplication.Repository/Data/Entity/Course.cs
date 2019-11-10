using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagementApplication.Core.Enum;
namespace SchoolManagementApplication.Repository.Data.Entity
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        public string CourseCode { get; set; }
        [Required]
        public string CourseDescription { get; set; }
        [Required]
        public SessionLevel SessionLevel { get; set; }
        [Required]
        public Semester Semester { get; set; }
        [Required]
        public int Unit { get; set; }
    }
}
