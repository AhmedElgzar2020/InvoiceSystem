using Microsoft.AspNetCore.Mvc;

namespace InvoiceSystem.Controllers
{
    public class IssueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
