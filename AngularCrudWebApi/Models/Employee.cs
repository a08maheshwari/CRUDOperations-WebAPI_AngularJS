using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AngularCrudWebApi.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        
        [Required]
        [StringLength(20)]
        public string EmpName { get; set; }

        public decimal Salary { get; set; }

        [Required]
        [StringLength(50)]
        public string  Country { get; set; }
        
        [Required]
        [StringLength(50)]
        public string State { get; set; }

        public DateTime DateOfBirth { get; set; }
        
    }
}