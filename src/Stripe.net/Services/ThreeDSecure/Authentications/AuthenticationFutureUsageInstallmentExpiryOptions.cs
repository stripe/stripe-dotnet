// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthenticationFutureUsageInstallmentExpiryOptions : INestedOptions
    {
        /// <summary>
        /// The date before which the last authorization related to this authentication will occur.
        /// </summary>
        [JsonProperty("date")]
        [STJS.JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// The type of expiry for the future use of this authentication.
        /// One of: <c>date</c>, or <c>never</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
