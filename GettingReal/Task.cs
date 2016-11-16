using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MEG
{
    public class Task
    {
        public Task(string ds, TaskType type, int spv) {
            TaskType task = (TaskType) Enum.Parse(typeof(TaskType), Enum.GetName(typeof(TaskType), 1));
            this.Description = ds;
            this.Type = type;
            this.StudentPointValue = spv; 
        }

        public string Description { get; set;}
        private TaskType Type { get; set; }
        public int StudentPointValue { get; set; }

    }
}
