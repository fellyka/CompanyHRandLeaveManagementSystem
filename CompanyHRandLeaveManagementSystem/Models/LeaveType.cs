namespace CompanyHRandLeaveManagementSystem.Models
{
    //This class defines types of leave and rules
    public class LeaveType
    {
        public int LeaveTypeId { get; set; }
        public string? Name { get; set; }
        public int MaxDaysAllowedPerYear { get; set; }
        public bool RequiresApproval { get; set; }
    }
}
