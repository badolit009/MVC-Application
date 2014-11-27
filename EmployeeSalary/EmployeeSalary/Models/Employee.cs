using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeSalary.Models
{
    public class Employee
    {
        public int Id { set; get; }
        [Display(Name = "Employee Id")]
        [Required(ErrorMessage = "EmployeeId is missing")]
        public string EmployeeId { get; set; }
        [Required(ErrorMessage = "Name is missing")]
        public string Name { set; get; }
        [Required(ErrorMessage = "Designation is missing")]
        public int DesignationId { get; set; }
        [Required(ErrorMessage = "Email is missing")]
        public string Email { set; get; }
        [Required(ErrorMessage = "Basic is missing")]
        public double Basic { set; get; }
        [Display(Name = "Convyance")]
        [Required(ErrorMessage = "Conveyance is missing")]
        public double ConveyancePercent { set; get; }
        [Display(Name = "House Rent")]
        [Required(ErrorMessage = "HouseRent is missing")]
        
        public double HouseRentPercent { set; get; }

        public virtual Designation Designations { get; set; }
    }
}