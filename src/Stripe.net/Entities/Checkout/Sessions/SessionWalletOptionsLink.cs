// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionWalletOptionsLink : StripeEntity<SessionWalletOptionsLink>
    {
        /// <summary>
        /// Describes whether Checkout should display Link. Defaults to <c>auto</c>.
        /// One of: <c>auto</c>, or <c>never</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("display")]
        [STJS.JsonPropertyName("display")]
        public string Display { get; set; }
    }
}
