﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string DepartmentName { get; set; }
        public int? ManagerId { get; set; }
        public Employee Manager { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}