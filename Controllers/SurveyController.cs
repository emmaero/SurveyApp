﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SurveyTest.Data;
using SurveyTest.Entities;
using SurveyTest.Models;
using SurveyTest.Helpers;

namespace SurveyTest.Controllers
{
    
    public class SurveyController : Controller
    {
        private readonly IMapper _mapper;

        private readonly SurveyResponseContext _dbContext;
        public SurveyController(SurveyResponseContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
       
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(SurveyResponseDTO survey)
        {
          if(ModelState.IsValid){
            var surveyResponse = _mapper.Map<SurveyResponse>(survey);
            _dbContext.SurveyResponses.Add(surveyResponse);
            _dbContext.SaveChanges();
            var model = new SurveyResponseDTO();
                TempData["success"] = "Thanks for your time";
                return RedirectToAction("Responses");
          }
          return View();

        }

        public IActionResult Responses(int? pageNumber)
        {
            int pageSize = 5;
            var result = PaginatedList<SurveyResponseDTO>.Create(_mapper.Map<IEnumerable<SurveyResponseDTO>>(_dbContext.SurveyResponses).ToList(),
            pageNumber ?? 1, pageSize);

            return View(result);
        }
           public IActionResult ResponsesPieChart()
        {

            var model = _mapper.Map<IEnumerable<SurveyResponseDTO>>(_dbContext.SurveyResponses).ToList();
            return PartialView("_SurveyPieChart",model);
        }
        
    }

}
