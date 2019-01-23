namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceCustomField : StripeEntity<InvoiceCustomField>
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
