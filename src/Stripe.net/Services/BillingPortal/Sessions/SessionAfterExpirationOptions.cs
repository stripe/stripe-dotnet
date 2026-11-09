// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionAfterExpirationOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for authenticating the customer after the session expires.
        /// </summary>
        [JsonProperty("customer_login")]
        [STJS.JsonPropertyName("customer_login")]
        public SessionAfterExpirationCustomerLoginOptions CustomerLogin { get; set; }

        /// <summary>
        /// The behavior to apply when the session expires.
        /// One of: <c>customer_login</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
