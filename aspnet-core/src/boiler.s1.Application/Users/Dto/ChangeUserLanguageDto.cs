using System.ComponentModel.DataAnnotations;

namespace boiler.s1.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}