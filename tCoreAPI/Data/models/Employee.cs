using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using tCoreAPI.Data.enums;

namespace tCoreAPI.Data.models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(100)]
        public string EmployeeName { get; set; }

        [Required]
        public Gender EmployeeGender { get; set; }

        [Required]
        public decimal Salary { get; set; }

        public int YearsOfExp { get; set; }

        public string Notes { get; set; }
    }
}
