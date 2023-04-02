using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SurveyTest.Data;
using SurveyTest.Models;

namespace SurveyTest.Components
{
    public class PieChartViewComponent: ViewComponent
    {
        private readonly IMapper _mapper;
          private readonly SurveyResponseContext _dbContext;
        public PieChartViewComponent(IMapper mapper, SurveyResponseContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync(){
            var model = _mapper.Map<IEnumerable<SurveyResponseDTO>>(_dbContext.SurveyResponses).ToList();
            
            return View(model);
        }
    }
}