using MVCAppFrederickson.Shared.Orchestrators.Interfaces;
using MVCAppFrederickson.Shared.ViewModels;
using System.Collections.Generic;

namespace MVCAppFrederickson.Shared.Orchestrators
{
    public class StudentOrchestrator : IStudentOrchestrator
    {
        public List<StudentViewModel> GetAllStudents()
        {
            var students = new List<StudentViewModel>
            {
                new StudentViewModel
                {
                    Age = 19,
                    FirstName = "Ben",
                    LastName = "Frederickson",
                    Major = "BIS",
                    StudentGender = Enums.GenderEnum.Male
                },
                new StudentViewModel
                {
                    Age = 19,
                    FirstName = "Olivia",
                    LastName = "Nanni",
                    Major = "CIS",
                    StudentGender = Enums.GenderEnum.Female
                }
            };

            return students;
        }
    }
}
