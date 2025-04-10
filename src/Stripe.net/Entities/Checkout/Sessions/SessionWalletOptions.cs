// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionWalletOptions : StripeEntity<SessionWalletOptions>
    {
        [JsonProperty("link")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("link")]
#endif
        public SessionWalletOptionsLink Link { get; set; }
    }
}
