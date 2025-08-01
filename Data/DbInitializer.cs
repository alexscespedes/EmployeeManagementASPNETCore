using System;
using EmployeeManagement.Models;

namespace EmployeeManagement.Data;

public static class DbInitializer
{
    public static void Seed(AppDbContext context)
    {
        if (context.Departments.Any() || context.Positions.Any() || context.Employees.Any())
            return;

        var departments = new List<Department>
        {
            new Department { Name = "Human Resources" },
            new Department { Name = "Engineering" },
            new Department { Name = "Sales" }
        };

        var positions = new List<Position>
        {
            new Position { Title = "Manager" },
            new Position { Title = "Software Engineer" },
            new Position { Title = "Sales Representative" }
        };

        context.Departments.AddRange(departments);
        context.Positions.AddRange(positions);
        context.SaveChanges();

        var employees = new List<Employee>
        {
            new Employee { FullName = "Alice Johnson", Age = 32, Salary = 70000, DepartmentId = departments[0].Id, PositionId = positions[0].Id },
            new Employee { FullName = "Bob Smith", Age = 28, Salary = 85000, DepartmentId = departments[1].Id, PositionId = positions[1].Id },
            new Employee { FullName = "Clara White", Age = 41, Salary = 60000, DepartmentId = departments[2].Id, PositionId = positions[2].Id }
        };

        context.Employees.AddRange(employees);
        context.SaveChanges();
    }
}
