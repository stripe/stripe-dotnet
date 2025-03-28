// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceItemParentSubscriptionDetails : StripeEntity<InvoiceItemParentSubscriptionDetails>
    {
        /// <summary>
        /// The subscription that generated this invoice item.
        /// </summary>
        [JsonProperty("subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription")]
#endif
        public string Subscription { get; set; }

        /// <summary>
        /// The subscription item that generated this invoice item.
        /// </summary>
        [JsonProperty("subscription_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_item")]
#endif
        public string SubscriptionItem { get; set; }
    }
}
