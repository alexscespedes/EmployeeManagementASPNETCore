using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models;

public class Employee
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    [Display(Name = "Full Name")]
    public string FullName { get; set; }

    [Range(18, 65)]
    public int Age { get; set; }

    [Required]
    [DataType(DataType.Currency)]
    public decimal Salary { get; set; }
    
    [Display(Name = "Department")]
    public int DepartmentId { get; set; }
    public Department? Department { get; set; }

    [Display(Name = "Position")]
    public int PositionId { get; set; }
    public Position? Position { get; set; }
}
