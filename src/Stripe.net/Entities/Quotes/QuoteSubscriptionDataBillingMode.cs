// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuoteSubscriptionDataBillingMode : StripeEntity<QuoteSubscriptionDataBillingMode>
    {
        [JsonProperty("flexible")]
        [STJS.JsonPropertyName("flexible")]
        public QuoteSubscriptionDataBillingModeFlexible Flexible { get; set; }

        /// <summary>
        /// Controls how prorations and invoices for subscriptions are calculated and orchestrated.
        /// One of: <c>classic</c>, or <c>flexible</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
