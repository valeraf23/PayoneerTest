namespace PayoneerTest.Models
{
    public class BeginRegistrationInfo
    {
        public string Password { get; set; }

        public string RetypePassword { get; set; }

        public string SecurityQuestions { get; set; }

        public string SecurityAnswer { get; set; }


        public string CompanyRegistrationNumber { get; set; }

        public string LAccountDetailsCaptcha { get; set; }
    }
}