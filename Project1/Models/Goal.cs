using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project1.Models
{
    public class Goal
    {
        [Required(ErrorMessage = "Please input a goal name")]
        [Display(Name = "Goal Name")]
        public string goalName { get; set; }

        [Required(ErrorMessage = "Please enter a goal description")]
        [Display(Name = "Goal Description")]
        public string goalDescription { get; set; }

        [Required(ErrorMessage = "Please choose a frequency")]
        [Display(Name = "Goal Frequency")]
        public string goalFrequency { get; set; }
        public List<Task> Tasks { get; set; }
    }
}