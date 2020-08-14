namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceSubscriptionItemBillingThresholdsOptions : INestedOptions
    {
        /// <summary>
        /// Usage threshold that triggers the subscription to advance to a new billing period.
        /// </summary>
        [JsonProperty("usage_gte")]
        public long? UsageGte { get; set; }
    }
}
