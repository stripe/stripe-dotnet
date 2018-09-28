namespace Stripe
{
    using Stripe.Infrastructure;

    public class CustomerTaxInfoOptions : INestedOptions
    {
        [FormProperty("tax_id")]
        public string TaxId { get; set; }

        [FormProperty("type")]
        public string Type { get; set; }
    }
}
