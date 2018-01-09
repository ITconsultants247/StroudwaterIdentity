using System.ComponentModel.DataAnnotations;

namespace StroudwaterIdentity.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}