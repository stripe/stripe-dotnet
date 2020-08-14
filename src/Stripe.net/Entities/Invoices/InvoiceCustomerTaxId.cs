namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceCustomerTaxId : StripeEntity<InvoiceCustomerTaxId>
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
