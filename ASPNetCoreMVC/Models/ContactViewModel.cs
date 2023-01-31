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

        public ContactFormViewModel FormModel { get; set; }
    }
}
