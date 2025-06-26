// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptionsKlarnaSubscriptionOptions : INestedOptions
    {
        /// <summary>
        /// Unit of time between subscription charges.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interval")]
#endif
        public string Interval { get; set; }

        /// <summary>
        /// The number of intervals (specified in the <c>interval</c> attribute) between
        /// subscription charges. For example, <c>interval=month</c> and <c>interval_count=3</c>
        /// charges every 3 months.
        /// </summary>
        [JsonProperty("interval_count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interval_count")]
#endif
        public long? IntervalCount { get; set; }

        /// <summary>
        /// Name for subscription.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// Describes the upcoming charge for this subscription.
        /// </summary>
        [JsonProperty("next_billing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("next_billing")]
#endif
        public PaymentIntentPaymentMethodOptionsKlarnaSubscriptionNextBillingOptions NextBilling { get; set; }

        /// <summary>
        /// A non-customer-facing reference to correlate subscription charges in the Klarna app. Use
        /// a value that persists across subscription charges.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public string Reference { get; set; }
    }
}
