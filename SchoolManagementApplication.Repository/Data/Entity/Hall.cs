using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagementApplication.Core.Enum;
namespace SchoolManagementApplication.Repository.Data.Entity
{

    public class Hall
    {
        [Key]
        public int HallId { get; set; }
        [Required]
        public string HallName { get; set; }
        [Required]
        public string HallDescription { get; set; }
        public int? OwnerId { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public UsageScope UsageScope { get; set; } 
        [Required]
        public DateTimeOffset DateCreated { get; set; }
    }
}