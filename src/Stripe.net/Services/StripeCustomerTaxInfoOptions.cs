namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeCustomerTaxInfoOptions : INestedOptions
    {
        [JsonProperty("tax_id")]
        public string TaxId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
