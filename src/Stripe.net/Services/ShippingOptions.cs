namespace Stripe
{
    using Stripe.Infrastructure;

    public class ShippingOptions : INestedOptions
    {
        [FormProperty("name")]
        public string Name { get; set; }

        [FormProperty("phone")]
        public string Phone { get; set; }

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
    }
}
