using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SchoolManagementApplication.Repository.Data.Entity
{
    [Table("Faculty", Schema = "dbo")]
    public class Faculty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "int")]
        [Display(Name = "Faculty Id")]
        public int FacultyId { get; set; }
        [Required]
        [Display(Name = "Faculty Name")]
        [Column(TypeName = "varchar(1024)")]
        public string FacaultyName { get; set; }
        [Required]
        [Display(Name = "Faculty Description")]
        [Column(TypeName = "varchar(max)")]
        public string FacultyDescription { get; set; }
        [Required]
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;
    }
}
