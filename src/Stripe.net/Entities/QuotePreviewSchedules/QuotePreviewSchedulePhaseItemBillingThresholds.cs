// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuotePreviewSchedulePhaseItemBillingThresholds : StripeEntity<QuotePreviewSchedulePhaseItemBillingThresholds>
    {
        /// <summary>
        /// Usage threshold that triggers the subscription to create an invoice.
        /// </summary>
        [JsonProperty("usage_gte")]
        public long? UsageGte { get; set; }
    }
}
