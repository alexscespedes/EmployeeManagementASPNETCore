using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models;

public class Position
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Title { get; set; }
    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
