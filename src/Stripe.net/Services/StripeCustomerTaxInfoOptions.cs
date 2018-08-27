namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeCustomerTaxInfoOptions : INestedOptions
    {
        [JsonProperty("tax_info[tax_id]")]
        public string TaxId { get; set; }

        [JsonProperty("tax_info[type]")]
        public string Type { get; set; }
    }
}
