using MVCAppFrederickson.Shared.ViewModels;
using System.Collections.Generic;

namespace MVCAppFrederickson.Shared.Orchestrators.Interfaces
{
    interface IStudentOrchestrator
    {
        List<StudentViewModel> GetAllStudents();
    }
}