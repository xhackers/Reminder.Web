using System;
using System.Collections.Generic;

namespace Reminder.Web.Models
{
    public partial class User
    {
        public User()
        {
            this.Messages = new List<Message>();
        }

        public string GUID { get; set; }
        public string Token { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
