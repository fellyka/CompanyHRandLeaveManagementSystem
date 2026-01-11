namespace CompanyHRandLeaveManagementSystem.Models
{
    //A class to represent all employees , including HR and Managers
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public DateOnly? DateEmployed { get; set; }

        public EmployeeRole Role { get; set; }
    }
}
