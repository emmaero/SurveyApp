using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SurveyTest.Models;

namespace SurveyTest.Data
{
    public class SurveyResponseContext: DbContext
    {
        public SurveyResponseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<SurveyResponse> SurveyResponses { get; set; }


    }
}
