using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WadExam.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Please enter a employee name")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Please enter a department")]
        public string Department { get; set; }
        [Required(ErrorMessage = "Please enter a salary")]
        public int Salary { get; set; }
    }
}