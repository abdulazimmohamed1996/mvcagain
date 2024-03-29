﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        public string Code { get; set; } =string.Empty;

        [Required]
        [MaxLength(50)]
        public string  Name { get; set; } =string.Empty;


        public DateTime  DateOfCreation { get; set; }


        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
