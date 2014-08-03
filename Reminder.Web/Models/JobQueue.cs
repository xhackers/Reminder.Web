using System;
using System.Collections.Generic;

namespace Reminder.Web.Models
{
    public partial class JobQueue
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public string Queue { get; set; }
        public Nullable<System.DateTime> FetchedAt { get; set; }
    }
}
