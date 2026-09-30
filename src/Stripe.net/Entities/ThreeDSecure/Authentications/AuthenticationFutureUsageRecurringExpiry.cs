// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthenticationFutureUsageRecurringExpiry : StripeEntity<AuthenticationFutureUsageRecurringExpiry>
    {
        [JsonProperty("date")]
        [STJS.JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// One of: <c>date</c>, or <c>never</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
