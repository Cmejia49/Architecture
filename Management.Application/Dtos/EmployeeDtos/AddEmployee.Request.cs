﻿using System.ComponentModel.DataAnnotations;

namespace Management.Application.Dtos.EmployeeDtos
{
    public class AddEmployeeRequest
    {
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(125)]
        public string LastName { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        public DateTime? BirthDate { get; set; }

        [Required]
        public int? DepartmentId { get; set; }
    }
}
