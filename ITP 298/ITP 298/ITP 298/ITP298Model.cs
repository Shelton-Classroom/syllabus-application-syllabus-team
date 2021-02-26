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
    [MetadataType(typeof(CategoryMetadata))]
    public partial class Employee
    {
        private sealed class CategoryMetadata
        {
            [Display(Name = "Employee ID")]
            public int EmployeeId { get; set; }

            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Display(Name = "Last Name")]
            public string LastName { get; set; }          

            [Display(Name = "Employee Status Id")]
            public int EmployeeStatusId { get; set; }

            [Display(Name = "Phone Number")]
            public int PhoneNum { get; set; }

            [Display(Name = "Office Hours")]
            public DateTime OfficeHours { get; set; }


        }
    }
}
