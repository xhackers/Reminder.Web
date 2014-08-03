using System;
using System.Collections.Generic;

namespace Reminder.Web.Models
{
    public partial class Counter
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public short Value { get; set; }
        public Nullable<System.DateTime> ExpireAt { get; set; }
    }
}
