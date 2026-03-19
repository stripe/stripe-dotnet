// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionAfterExpirationOptions : INestedOptions
    {
        /// <summary>
        /// Configure a Checkout Session that can be used to recover an expired session.
        /// </summary>
        [JsonProperty("recovery")]
        [STJS.JsonPropertyName("recovery")]
        public SessionAfterExpirationRecoveryOptions Recovery { get; set; }
    }
}
