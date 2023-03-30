using System.ComponentModel.DataAnnotations;

namespace SurveyTest.Models
{
    public class SurveyResponse
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your age.")]
        [Range(18, 100, ErrorMessage = "You must be between 18 and 100 years old.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please select your gender.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please answer the question.")]
        public List<string> Question { get; set; }
    }
}
