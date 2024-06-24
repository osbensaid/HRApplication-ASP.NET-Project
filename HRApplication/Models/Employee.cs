using System;
using System.ComponentModel.DataAnnotations;

namespace HRApplication.Models
{
    public class Employee
    {
        // Name
        [Required(ErrorMessage = "Please Enter Name.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid Name")]
        public string EmployeeName { get; set; }
        // Department
        [Required(ErrorMessage = "Please Select Department")]
        public string Department { get; set; }
        // is Active
        public bool isActive { get; set; }
        // Job Title
        [Required(ErrorMessage = "Please Enter Job Title.")]
        public string JobTitle { get; set; }
        // Date of Birth
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }
        // Email Address
        [Required(ErrorMessage = "Please Enter Email.")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

    }
}
