using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1.Models
{
    public class Goal
    {
        public string goalDescription { get; set; }
        public string goalFrequency { get; set; }
        public List<Task> Tasks { get; set; }
    }
}