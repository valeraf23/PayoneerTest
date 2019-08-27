using PayoneerTest.Helpers.GenerationAttributes;

namespace PayoneerTest.Models
{
    public class DetailsSecurityInfo
    {
        [Generation] public string CompanyName { get; set; }
        public string BusinessOrganization { get; set; }
        [Generation] public string FirstName { get; set; }
        [Generation] public string LastName { get; set; }
        [EmailGeneration] public string Email { get; set; }
        [Generation] public string ConfirmEmail { get; set; }
        [DateGeneration("MM/dd/yyyy")] public string Birthday { get; set; }
    }
}