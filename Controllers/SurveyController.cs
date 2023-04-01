using Microsoft.AspNetCore.Mvc;
using SurveyTest.Data;
using SurveyTest.Entities;
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
        public async Task<IActionResult> Index(Survey surveyResponse)
        {
            var survey = new SurveyResponse()
            {
                Name = surveyResponse.Name,
                Age = surveyResponse.Age,
                Gender = surveyResponse.Gender,
                Question = surveyResponse.Question
            };
            // _dbContext.SurveyResponses.Add(surveyResponse);
            // _dbContext.SaveChanges();
            var model = new Survey();
            return RedirectToAction("Reponses");
        }

        public IActionResult Responses()
        {
       
            // var result = _dbContext.SurveyResponses.ToList();
            return View();
        }
    }

}
