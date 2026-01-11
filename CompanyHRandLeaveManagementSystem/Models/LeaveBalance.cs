namespace CompanyHRandLeaveManagementSystem.Models
{
    //This class tracks leave allocation and usage per employee per leave type
    public class LeaveBalance
    {
        public int LeaveBalanceId { get; set; }
        public int EmployeeId { get; set; }//FK to Employee
        public int LeaveTypeId { get; set; }//FK to LeaveType

        public int TotalDays { get; set; }
        public int UsedDays { get; set; }
        public int RemainingDays { get; set; }
    }
}
