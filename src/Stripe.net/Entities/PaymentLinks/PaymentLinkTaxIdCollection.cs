// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkTaxIdCollection : StripeEntity<PaymentLinkTaxIdCollection>
    {
        /// <summary>
        /// Indicates whether tax ID collection is enabled for the session.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool Enabled { get; set; }

        /// <summary>
        /// One of: <c>if_supported</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("required")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("required")]
#endif
        public string Required { get; set; }
    }
}
