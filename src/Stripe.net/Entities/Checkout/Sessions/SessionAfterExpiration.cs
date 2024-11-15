// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionAfterExpiration : StripeEntity<SessionAfterExpiration>
    {
        /// <summary>
        /// When set, configuration used to recover the Checkout Session on expiry.
        /// </summary>
        [JsonProperty("recovery")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recovery")]
#endif

        public SessionAfterExpirationRecovery Recovery { get; set; }
    }
}
