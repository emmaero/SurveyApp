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
            var model = new Survey(){
                Checkboxes = new List<QuestionOption>
            {
                new QuestionOption() {
                    IsChecked = false,
                    Description = "Yes",
                    Value = "1",
                },
                 new QuestionOption() {
                    IsChecked = false,
                    Description = "Not sure",
                    Value = "2",
                },
                  new QuestionOption() {
                    IsChecked = false,
                    Description = "No",
                    Value = "3",
                },

            }
                };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(Survey surveyResponse)
        {
            var model = new Survey();
            return View(model);
        }

        public IActionResult Results()
        {
       
            var result = _dbContext.SurveyResponses.ToList();
            return View(result);
        }
    }

}
