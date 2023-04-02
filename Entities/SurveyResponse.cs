using SurveyTest.Models;
using System.ComponentModel.DataAnnotations;

namespace SurveyTest.Entities
{
    public class SurveyResponse
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Question { get; set; }

    
    }
}
