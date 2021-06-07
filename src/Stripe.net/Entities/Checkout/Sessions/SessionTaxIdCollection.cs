// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionTaxIdCollection : StripeEntity<SessionTaxIdCollection>
    {
        /// <summary>
        /// Indicates whether tax ID collection is enabled for the session.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}
