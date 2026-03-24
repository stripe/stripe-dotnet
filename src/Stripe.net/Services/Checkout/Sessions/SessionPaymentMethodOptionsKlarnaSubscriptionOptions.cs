// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionPaymentMethodOptionsKlarnaSubscriptionOptions : INestedOptions
    {
        /// <summary>
        /// Unit of time between subscription charges.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
        [STJS.JsonPropertyName("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The number of intervals (specified in the <c>interval</c> attribute) between
        /// subscription charges. For example, <c>interval=month</c> and <c>interval_count=3</c>
        /// charges every 3 months.
        /// </summary>
        [JsonProperty("interval_count")]
        [STJS.JsonPropertyName("interval_count")]
        public long? IntervalCount { get; set; }

        /// <summary>
        /// Name for subscription.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Describes the upcoming charge for this subscription.
        /// </summary>
        [JsonProperty("next_billing")]
        [STJS.JsonPropertyName("next_billing")]
        public SessionPaymentMethodOptionsKlarnaSubscriptionNextBillingOptions NextBilling { get; set; }

        /// <summary>
        /// A non-customer-facing reference to correlate subscription charges in the Klarna app. Use
        /// a value that persists across subscription charges.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
