namespace CompanyHRandLeaveManagementSystem.Models
{
    //This class stores leave application and tracks approval workflow
    public class LeaveRequest
    {
        public int LeaveRequestId { get; set; }
        public int EmployeeId { get; set; } //FK to Employee(who requested)

        //When a request is Pending, nobody has approved it yet, so ApprovedById is nullable
        public int? ApprovedById { get; set; } //FK to Employee(approver)
        public int LeaveTypeId { get; set; }//FK to LeaveType

        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public DateOnly DateApplied { get; set; }
        public string? Reason { get; set; }
        public int NumberOfDays { get; set; }
        public  LeaveRequestStatus Status { get; set; }

        public string? Comments { get; set; }

    }
}
