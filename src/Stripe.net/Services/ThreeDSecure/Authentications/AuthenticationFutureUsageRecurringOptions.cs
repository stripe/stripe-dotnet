// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthenticationFutureUsageRecurringOptions : INestedOptions
    {
        /// <summary>
        /// A non-negative integer representing the future authorizations' amount in the <a
        /// href="https://stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Information about the expiry of the future usage of this authentication.
        /// </summary>
        [JsonProperty("expiry")]
        [STJS.JsonPropertyName("expiry")]
        public AuthenticationFutureUsageRecurringExpiryOptions Expiry { get; set; }

        /// <summary>
        /// The unit of time for <c>interval_count</c>.
        /// </summary>
        [JsonProperty("interval")]
        [STJS.JsonPropertyName("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The minimum number of time intervals between authorizations. Must be greater than 0, and
        /// defaults to 1.
        /// </summary>
        [JsonProperty("interval_count")]
        [STJS.JsonPropertyName("interval_count")]
        public long? IntervalCount { get; set; }
    }
}
