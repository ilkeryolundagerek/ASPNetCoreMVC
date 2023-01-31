using System.ComponentModel.DataAnnotations;

namespace ASPNetCoreMVC.Models
{
    public class ContactViewModel
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        [Required]
        [Display(Name = "Firstname", Prompt = "Firstname")]
        [MinLength(3)]
        [MaxLength(25)]
        public string FormFirstname { get; set; }

        [Required]
        [Display(Name = "Lastname", Prompt = "Lastname")]
        [MinLength(3)]
        [MaxLength(25)]
        public string FormLastname { get; set; }

        [Required]
        [Display(Name = "E-Mail Address", Prompt = "E-Mail Address")]
        [EmailAddress]
        public string FormEMail { get; set; }

        [Required]
        [Display(Name = "Subject", Prompt = "Subject")]
        [MinLength(5), MaxLength(150)]
        public string FormSubject { get; set; }

        [Required]
        [Display(Name = "Message", Prompt = "Message")]
        [MinLength(15), MaxLength(1000)]
        [DataType(DataType.MultilineText)]
        public string FormMessage { get; set; }
    }
}
