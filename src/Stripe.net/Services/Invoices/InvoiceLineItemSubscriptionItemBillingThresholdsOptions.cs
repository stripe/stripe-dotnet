namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceLineItemSubscriptionItemBillingThresholdsOptions : ListOptions
    {
        [JsonProperty("usage_gte")]
        public long? UsageGte { get; set; }
    }
}
