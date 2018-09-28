namespace Stripe.Issuing
{
    using Stripe.Infrastructure;

    public class BillingOptions : INestedOptions
    {
        [FormProperty("address[city]")]
        public string City { get; set; }

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

        // Keep this one separate as it's not on the same level in the API.
        [FormProperty("name")]
        public string Name { get; set; }
    }
}
