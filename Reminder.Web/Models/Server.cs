using System;
using System.Collections.Generic;

namespace Reminder.Web.Models
{
    public partial class Server
    {
        public string Id { get; set; }
        public string Data { get; set; }
        public System.DateTime LastHeartbeat { get; set; }
    }
}
