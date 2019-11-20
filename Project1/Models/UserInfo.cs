using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1.Models
{
    public class UserInfo
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public EmailService email { get; set; }
        public String password { get; set; }

        public List<Goal> Goals { get; set; }
    }
}