// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkTaxIdCollection : StripeEntity<PaymentLinkTaxIdCollection>
    {
        /// <summary>
        /// Indicates whether tax ID collection is enabled for the session.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// One of: <c>if_supported</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("required")]
        public string Required { get; set; }
    }
}
