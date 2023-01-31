using System.ComponentModel.DataAnnotations;

namespace ASPNetCoreMVC.Models
{
    public class SignUpFormViewModel
    {
        [Required]
        [Display(Name = "Firstname", Prompt = "Firstname")]
        [MinLength(3)]
        [MaxLength(25)]
        public string Firstname { get; set; }

        [Required]
        [Display(Name = "Lastname", Prompt = "Lastname")]
        [MinLength(3)]
        [MaxLength(25)]
        public string Lastname { get; set; }

        [Required]
        [Display(Name = "E-Mail Address", Prompt = "E-Mail Address")]
        [EmailAddress]
        public string EMail { get; set; }

        [Required,Display(Name = "Password", Prompt = "Password")]
        //[RegularExpression("")]
        [DataType(DataType.Password)]
        [Compare(nameof(RepeatPassword))]
        public string Password { get; set; }

        [Required, Display(Name = "Password Repeat", Prompt = "Password Repeat")]
        //[RegularExpression("")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string RepeatPassword { get; set; }
    }
}
