// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkNameCollectionBusiness : StripeEntity<PaymentLinkNameCollectionBusiness>
    {
        /// <summary>
        /// Indicates whether business name collection is enabled for the payment link.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool Enabled { get; set; }

        /// <summary>
        /// Whether the customer is required to complete the field before checking out. Defaults to
        /// <c>false</c>.
        /// </summary>
        [JsonProperty("optional")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("optional")]
#endif
        public bool Optional { get; set; }
    }
}
