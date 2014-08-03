using System;
using System.Collections.Generic;

namespace Reminder.Web.Models
{
    public partial class Job
    {
        public Job()
        {
            this.JobParameters = new List<JobParameter>();
            this.States = new List<State>();
        }

        public int Id { get; set; }
        public Nullable<int> StateId { get; set; }
        public string StateName { get; set; }
        public string InvocationData { get; set; }
        public string Arguments { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public Nullable<System.DateTime> ExpireAt { get; set; }
        public virtual ICollection<JobParameter> JobParameters { get; set; }
        public virtual ICollection<State> States { get; set; }
    }
}
