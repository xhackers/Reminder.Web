using System;
using System.Collections.Generic;

namespace Reminder.Web.Models
{
    public partial class List
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public Nullable<System.DateTime> ExpireAt { get; set; }
    }
}
