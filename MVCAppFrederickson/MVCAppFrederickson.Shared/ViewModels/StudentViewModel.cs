using MVCAppFrederickson.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace MVCAppFrederickson.Shared.ViewModels
{
    public class StudentViewModel
    {
        [Display(Name = "First Name: ")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name: ")]
        public string LastName { get; set; }

        [Display(Name = "Age: ")]
        public int Age { get; set; }

        [Display(Name = "Major: ")]
        public string Major { get; set; }

        [Display(Name = "Student Gender: ")]
        public GenderEnum StudentGender { get; set; }

    }
}