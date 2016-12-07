using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEG
{
    public class Task
    {
        public Task(string ds, TaskType type, int spv, TaskStatus status) {
            this.Description = ds;
            this.Type = type;
            this.StudentPointValue = spv;
            this.Status = status;
        }

        public string Description { get; set;}
        private TaskType Type { get; set; }
        public int StudentPointValue { get; set; }
        public TaskStatus Status { get; set; }
    }
}
