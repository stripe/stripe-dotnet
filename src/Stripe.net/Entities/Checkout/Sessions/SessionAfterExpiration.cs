// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionAfterExpiration : StripeEntity<SessionAfterExpiration>
    {
        /// <summary>
        /// When set, configuration used to recover the Checkout Session on expiry.
        /// </summary>
        [JsonProperty("recovery")]
        [STJS.JsonPropertyName("recovery")]
        public SessionAfterExpirationRecovery Recovery { get; set; }
    }
}
