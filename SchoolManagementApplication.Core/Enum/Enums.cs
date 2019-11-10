using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolManagementApplication.Core.Enum
{
    public enum UsageScope : int
    {
        DepartmentalLevel = 1,
        FacultyLevel = 2,
        TheWholeSchool = 3
    }
    public enum SessionLevel : int
    {
        Level100 = 1,
        Level200 = 2,
        Level300 = 3,
        Level400 = 4,
        Level500 = 5
    }
    public enum Semester : int { First = 1, Second = 2}
    public enum LecturerTitle : int {
        [Description("Principal Lecturer")]
        [Display( Name = "Principal Lecturer")]
        Principal_Lecturer = 1,

        [Description("Senior Lecturer FullTime")]
        [Display(Name = "Senior Lecturer FullTime")]
        Senior_Lecturer_FullTime = 2,

        [Description("Senior Lecturer PartTime")]
        [Display(Name = "Senior Lecturer PartTime")]
        Senior_Lecturer_PartTime = 3,

        [Description("Senior Lecturer PartTime Quarterly")]
        [Display(Name = "Senior Lecturer PartTime Quarterly")]
        Senior_Lecturer_PartTime_Quarterly = 4,

        [Description("Lecturer Full-Time")]
        [Display(Name = "Lecturer Full-Time")]
        Lecturer_FullTime = 5,

        [Description("Lecturer Full-Time Temporary")]
        [Display(Name = "Lecturer Full-Time Temporary")]
        Lecturer_FullTime_Temporary = 6,

        [Description("Lecturer Part-Time")]
        [Display(Name = "Lecturer Part-Time")]
        Lecturer_Part_Time = 7,

        [Description("Lecturer Part-Time Temporary")]
        [Display(Name = "Lecturer Part-Time Temporary")]
        Lecturer_PartTime_Temporary = 8
    }
}
