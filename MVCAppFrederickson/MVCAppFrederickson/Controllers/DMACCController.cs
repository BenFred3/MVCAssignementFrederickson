using MVCAppFrederickson.Models;
using MVCAppFrederickson.Shared.Orchestrators;
using System.Web.Mvc;

namespace MVCAppFrederickson.Controllers
{
    public class DMACCController : Controller
    {
        public ActionResult Index()
        {
            var studentOrchestrator = new StudentOrchestrator();

            var model = new DMACCModel
            {
                Students = studentOrchestrator.GetAllStudents()
            };

            return View(model);
        }
    }
}