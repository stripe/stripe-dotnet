// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionAfterExpirationOptions : INestedOptions
    {
        /// <summary>
        /// Configure a Checkout Session that can be used to recover an expired session.
        /// </summary>
        [JsonProperty("recovery")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recovery")]
#endif

        public SessionAfterExpirationRecoveryOptions Recovery { get; set; }
    }
}
