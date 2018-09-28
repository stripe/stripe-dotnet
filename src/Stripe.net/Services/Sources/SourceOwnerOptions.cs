namespace Stripe
{
    using Stripe.Infrastructure;

    public class SourceOwnerOptions : INestedOptions
    {
        [FormProperty("[owner][address][city]")]
        public string CityOrTown { get; set; }

        [FormProperty("[owner][address][country]")]
        public string Country { get; set; }

        [FormProperty("[owner][address][line1]")]
        public string Line1 { get; set; }

        [FormProperty("[owner][address][line2]")]
        public string Line2 { get; set; }

        [FormProperty("[owner][address][postal_code]")]
        public string PostalCode { get; set; }

        [FormProperty("[owner][address][state]")]
        public string State { get; set; }

        [FormProperty("[owner][email]")]
        public string Email { get; set; }

        [FormProperty("[owner][name]")]
        public string Name { get; set; }

        [FormProperty("[owner][phone]")]
        public string Phone { get; set; }
    }
}
