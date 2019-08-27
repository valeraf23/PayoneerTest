using PayoneerTest.Helpers.GenerationAttributes;

namespace PayoneerTest.Models
{
    public class ContactDataInfo
    {
        [Generation] public string Address { get; set; }

        public string City { get; set; }
        [GenerationNumber] public string Zip { get; set; }

        [GenerationNumber]
        public string ContactPersonPhoneNumber { get; set; }
    }
}