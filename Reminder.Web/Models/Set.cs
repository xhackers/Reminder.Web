using System;
using System.Collections.Generic;

namespace Reminder.Web.Models
{
    public partial class Set
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public double Score { get; set; }
        public string Value { get; set; }
        public Nullable<System.DateTime> ExpireAt { get; set; }
    }
}
