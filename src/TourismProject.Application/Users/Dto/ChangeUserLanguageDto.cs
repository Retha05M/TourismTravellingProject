using System.ComponentModel.DataAnnotations;

namespace TourismProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}