using System.Collections.Generic;
using MVCAppFrederickson.Shared.Enums.Orchestrators.Interfaces;
using MVCAppFrederickson.Shared.ViewModels;

namespace MVCAppFrederickson.Shared.Enums.Orchestrators
{
    public class CampusOrchestrator : ICampusOrchestrator
    {
        public List<CampusViewModel> GetAllStudents()
        {
            var campuses = new List<CampusViewModel>
            {
                new CampusViewModel
                {
                    CollegeName = "DMACC",
                    CampusName = "Ankeny"
                },
                new CampusViewModel
                {
                    CollegeName = "DMACC",
                    CampusName = "Urban"
                }
            };

            return campuses;
        }
    }
}
