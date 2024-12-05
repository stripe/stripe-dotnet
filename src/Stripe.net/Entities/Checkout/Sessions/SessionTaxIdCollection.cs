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

        /// <summary>
        /// Indicates whether a tax ID is required on the payment page.
        /// One of: <c>if_supported</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("required")]
        public string Required { get; set; }
    }
}
