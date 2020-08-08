namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceSubscriptionItemBillingThresholdsOptions : INestedOptions
    {
        [JsonProperty("usage_gte")]
        public long? UsageGte { get; set; }
    }
}
