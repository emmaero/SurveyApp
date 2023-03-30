using Microsoft.AspNetCore.Mvc;

namespace SurveyTest.Controllers
{
    public class SurveyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
    public IActionResult Results()
    {
        using (var context = new SurveyResponseContext())
        {
            var responses = context.SurveyResponses.ToList();
            return View(responses);
        }
    }
}
