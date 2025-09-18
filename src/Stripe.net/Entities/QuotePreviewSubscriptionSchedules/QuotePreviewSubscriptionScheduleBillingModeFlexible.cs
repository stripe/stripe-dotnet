// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuotePreviewSubscriptionScheduleBillingModeFlexible : StripeEntity<QuotePreviewSubscriptionScheduleBillingModeFlexible>
    {
        /// <summary>
        /// When true, proration line items will show accurate discount amounts and use gross
        /// amounts, making them consistent with non-proration line items.
        /// </summary>
        [JsonProperty("consistent_proration_discount_amounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("consistent_proration_discount_amounts")]
#endif
        public bool ConsistentProrationDiscountAmounts { get; set; }
    }
}
