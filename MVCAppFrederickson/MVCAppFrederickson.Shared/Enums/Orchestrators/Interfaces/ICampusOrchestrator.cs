using MVCAppFrederickson.Shared.ViewModels;
using System.Collections.Generic;

namespace MVCAppFrederickson.Shared.Enums.Orchestrators.Interfaces
{
    public interface ICampusOrchestrator
    {
        List<CampusViewModel> GetAllStudents();
    }
}
