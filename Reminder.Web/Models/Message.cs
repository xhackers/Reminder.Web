using System;
using System.Collections.Generic;

namespace Reminder.Web.Models
{
    public partial class Message
    {
        public string GUID { get; set; }
        public string UserGUID { get; set; }
        public Nullable<System.DateTime> DateOFBirth { get; set; }
        public string Message1 { get; set; }
        public Nullable<bool> Notify { get; set; }
        public Nullable<bool> Status { get; set; }
        public virtual User User { get; set; }
    }
}
