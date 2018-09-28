namespace Stripe
{
    using Stripe.Infrastructure;

    public class AccountAdditionalOwner : INestedOptions
    {
        [FormProperty("address[city]")]
        public string CityOrTown { get; set; }

        [FormProperty("address[country]")]
        public string Country { get; set; }

        [FormProperty("address[line1]")]
        public string Line1 { get; set; }

        [FormProperty("address[line2]")]
        public string Line2 { get; set; }

        [FormProperty("address[postal_code]")]
        public string PostalCode { get; set; }

        [FormProperty("address[state]")]
        public string State { get; set; }

        [FormProperty("dob[day]")]
        public int? BirthDay { get; set; }

        [FormProperty("dob[month]")]
        public int? BirthMonth { get; set; }

        [FormProperty("dob[year]")]
        public int? BirthYear { get; set; }

        [FormProperty("first_name")]
        public string FirstName { get; set; }

        [FormProperty("last_name")]
        public string LastName { get; set; }

        [FormProperty("verification[document]")]
        public string VerificationDocument { get; set; }

        [FormProperty("verification[document_back]")]
        public string VerificationDocumentBack { get; set; }
    }
}
