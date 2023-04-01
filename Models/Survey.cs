using System.ComponentModel.DataAnnotations;

namespace SurveyTest.Models
{
    public class Survey
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your age.")]
        [Range(18, 100, ErrorMessage = "You must be between 18 and 100 years old.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please select your gender.")]
        public string Gender { get; set; }
        [Display(Name ="Will you vote in the upcoming election?")]
        [Required(ErrorMessage = "Please answer the question.")]
        public string Question { get; set; }
     

    }
}
