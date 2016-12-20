using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GettingReal;

namespace MEG
{
    public class Assignment
    {
        private AssignmentStatus assignmentStatus;
        private DateTime startTime;
        private string name;
        private AssignmentType tasktype;
        private int sp;
        private AssignmentStatus assignementStatus;
        private string username;

        public Assignment(string name,string ds, AssignmentType type, int spv, AssignmentStatus status, string creator, DateTime endTime)
        {
            this.assignmentStatus = status;
            this.Description = ds;
            this.Type = type;
            this.StudentPointValue = spv;
            this.CreatedBy = creator;
            this.EndTime = endTime;
            this.startTime = DateTime.Today;
        }

        public Assignment(string description, AssignmentType tasktype, int sp, AssignmentStatus assignementStatus, string username, DateTime endTime)
        {
            Description = description;
            this.tasktype = tasktype;
            this.sp = sp;
            this.assignementStatus = assignementStatus;
            this.username = username;
            EndTime = endTime;
        }

        public override string ToString() {
            return "Assignment[Status=" + this.assignmentStatus +",Type="+ this.Type + ", StudentPointValue="+ this.StudentPointValue +", CreatedBy=" + this.CreatedBy + ", StartDate="+ this.GetStartDate() + ", EndDate="+ this.GetEndDate() + "Description="+ this.Description+ "]";
        }

        private DateTime EndTime{ get; set; }
        public string Description { get; set;}
        private AssignmentType Type { get; set; }
        public int StudentPointValue { get; set; }
        public string CreatedBy { get; set; }

        public string GetEndDate()
        {
            return FormatDate(EndTime);
        }

        public string GetStartDate()
        {
            return FormatDate(startTime);
        }

        private string FormatDate(DateTime d) {
            string rs = "";
            rs = d.Day + "/" + d.Month + "/" + d.Year;
            return rs;
        }
    }
}
