﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Employees_MVC.Entities
{
    public class Employee
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
       

        public Employee Manager { get; set; }

    }
}