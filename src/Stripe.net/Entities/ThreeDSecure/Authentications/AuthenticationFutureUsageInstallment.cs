// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthenticationFutureUsageInstallment : StripeEntity<AuthenticationFutureUsageInstallment>
    {
        /// <summary>
        /// A non-negative integer representing the amount in the <a
        /// href="https://stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Information about recurring payment expiry.
        /// </summary>
        [JsonProperty("expiry")]
        [STJS.JsonPropertyName("expiry")]
        public AuthenticationFutureUsageInstallmentExpiry Expiry { get; set; }

        /// <summary>
        /// The unit of time for <c>interval_count</c>.
        /// </summary>
        [JsonProperty("interval")]
        [STJS.JsonPropertyName("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The minimum number of time intervals between authorizations.
        /// </summary>
        [JsonProperty("interval_count")]
        [STJS.JsonPropertyName("interval_count")]
        public long IntervalCount { get; set; }

        /// <summary>
        /// The maximum number of installments.
        /// </summary>
        [JsonProperty("number")]
        [STJS.JsonPropertyName("number")]
        public long Number { get; set; }
    }
}
