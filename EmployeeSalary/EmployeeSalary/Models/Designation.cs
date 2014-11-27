using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeSalary.Models
{
    public class Designation
    {
        public int DesignationId { get; set; }
        [Display(Name = "Designation")]
        public string  Name { get; set; }
    }
}