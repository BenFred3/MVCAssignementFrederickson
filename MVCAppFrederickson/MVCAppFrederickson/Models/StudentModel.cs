using MVCAppFrederickson.Shared.Enums;
using MVCAppFrederickson.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVCAppFrederickson.Models
{
    public class StudentModel
    {
        [DisplayName("First Name:")]
        public string FirstName { get; set; }

        [DisplayName("Last Name:")]
        public string LastName { get; set; }

        [DisplayName("Age:")]
        public int Age { get; set; }

        [DisplayName("Major:")]
        public string Major { get; set; }

        public GenderEnum Gender { get; set; }

        [DisplayName("Student Gender:")]
        public string StudentGender => Gender.ToString();

        public List<CampusViewModel> Students { get; set; }
    }
}