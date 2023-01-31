using System.ComponentModel.DataAnnotations;

namespace ASPNetCoreMVC.Models
{
    public class ContactFormViewModel
    {
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
        [Display(Name = "Phone Number", Prompt = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("(\\+90|0)?5[0345][0-9]{8}",ErrorMessage ="5xx, 05xx, +905xx ile başlamalıdır.")]
        public string FormPhone { get; set; }

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
