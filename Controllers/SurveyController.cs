using Microsoft.AspNetCore.Mvc;
using SurveyTest.Data;
using SurveyTest.Models;

namespace SurveyTest.Controllers
{
    public class SurveyController : Controller
    {
        private readonly SurveyResponseContext _dbContext;
        public SurveyController(SurveyResponseContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(SurveyResponse surveyResponse)
        {
            var model = new SurveyResponse();
            return View(model);
        }

        public IActionResult Results()
        {
       
            var result = _dbContext.SurveyResponses.ToList();
            return View(result);
        }
    }

}
