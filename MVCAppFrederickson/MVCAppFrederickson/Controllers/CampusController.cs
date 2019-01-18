using MVCAppFrederickson.Models;
using MVCAppFrederickson.Shared.Enums;
using MVCAppFrederickson.Shared.Enums.Orchestrators;
using System.Web.Mvc;

namespace MVCAppFrederickson.Controllers
{
    public class CampusController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var studentOrchestrator = new CampusOrchestrator();

            var studentModel = new StudentModel
            {
                FirstName = "Ben",
                LastName = "Frederickson",
                Age = 19,
                Major = "BIS",
                Gender = GenderEnum.Male,
                Students = studentOrchestrator.GetAllStudents()
            };

            return View(studentModel);
        }
    }
}