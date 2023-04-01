using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SurveyTest.Entities;
using SurveyTest.Models;
using AutoMapper;

namespace SurveyTest.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<SurveyResponse, Survey>();
             CreateMap<Survey, SurveyResponse>();
        }
    }
}