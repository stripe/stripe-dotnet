// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodCustomLogo : StripeEntity<PaymentMethodCustomLogo>
    {
        /// <summary>
        /// Content type of the Dashboard-only CustomPaymentMethodType logo.
        /// </summary>
        [JsonProperty("content_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("content_type")]
#endif
        public string ContentType { get; set; }

        /// <summary>
        /// URL of the Dashboard-only CustomPaymentMethodType logo.
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif
        public string Url { get; set; }
    }
}
