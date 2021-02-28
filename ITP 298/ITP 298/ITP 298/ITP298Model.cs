using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Web;


namespace ITP_298
{
    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee
    {
        public string Name => $"{FirstName} {LastName}";
        private sealed class EmployeeMetadata
        {
            [Display(Name = "Employee ID")]
            public int EmployeeId { get; set; }

            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Display(Name = "Employee Status")]
            public int EmployeeStatusId { get; set; }

            [Display(Name = "Phone Number")]
            public int PhoneNum { get; set; }

            [Display(Name = "Office Hours")]
            public DateTime OfficeHours { get; set; }

            [Display(Name = "Email")]
            public string LoginUserId { get; set; }


        }
    }

    [MetadataType(typeof(AspNetUserMetadata))]
    public partial class AspNetUser
    {
        private sealed class AspNetUserMetadata
        {

        }

    }

    [MetadataType(typeof(CourseMetadata))]

    public partial class Course
    {

        public sealed class CourseMetadata
        {
            //[Display(Name = "Title")]
            //public string Title { get; set; }

            //[Display(Name = "Credits")]
            //public int Credit { get; set; }

            //[Display(Name = "Description")]
            //public string Description { get; set; }

            //[Display(Name = "Prerequisite")]
            //public string Preriquisite { get; set; }

            [Display(Name = "Credits")]
            public int Credit { get; set; }

            [Display(Name = "Department Code")]
            public string DepartmentCode { get; set; }

            [Display(Name = "Course Number")]
            public int CourseNumber { get; set; }


        }
    }
}
