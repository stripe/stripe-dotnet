// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionAfterExpirationOptions : INestedOptions
    {
        /// <summary>
        /// Configure a Checkout Session that can be used to recover an expired session.
        /// </summary>
        [JsonProperty("recovery")]
        public SessionAfterExpirationRecoveryOptions Recovery { get; set; }
    }
}
