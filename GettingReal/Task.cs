using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GettingReal;

namespace MEG
{
    public class Task
    {
        private AssignmentStatus assignmentStatus;

        public Task(string ds, TaskType type, int spv, AssignmentStatus status)
        {
            this.assignmentStatus = status;
            this.Description = ds;
            this.Type = type;
            this.StudentPointValue = spv;
        }

        public string Description { get; set;}
        private TaskType Type { get; set; }
        public int StudentPointValue { get; set; }

    }
}
