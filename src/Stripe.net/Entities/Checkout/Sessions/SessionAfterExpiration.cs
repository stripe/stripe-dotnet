// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionAfterExpiration : StripeEntity<SessionAfterExpiration>
    {
        /// <summary>
        /// When set, configuration used to recover the Checkout Session on expiry.
        /// </summary>
        [JsonProperty("recovery")]
        public SessionAfterExpirationRecovery Recovery { get; set; }
    }
}
