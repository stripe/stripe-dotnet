// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteSubscriptionDataBillingMode : StripeEntity<QuoteSubscriptionDataBillingMode>
    {
        [JsonProperty("flexible")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flexible")]
#endif
        public QuoteSubscriptionDataBillingModeFlexible Flexible { get; set; }

        /// <summary>
        /// Controls how prorations and invoices for subscriptions are calculated and orchestrated.
        /// One of: <c>classic</c>, or <c>flexible</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
