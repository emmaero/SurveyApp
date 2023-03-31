using SurveyTest.Models;
using System.ComponentModel.DataAnnotations;

namespace SurveyTest.Entities
{
    public class SurveyResponse
    {
        public int Id { get; set; }
   
        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public List<string> Question { get; set; }
    }
}
