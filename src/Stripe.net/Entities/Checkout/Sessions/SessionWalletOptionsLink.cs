// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionWalletOptionsLink : StripeEntity<SessionWalletOptionsLink>
    {
        /// <summary>
        /// Describes whether Checkout should display Link. Defaults to <c>auto</c>.
        /// One of: <c>auto</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("display")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display")]
#endif
        public string Display { get; set; }
    }
}
