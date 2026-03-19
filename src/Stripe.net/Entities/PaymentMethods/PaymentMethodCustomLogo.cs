// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentMethodCustomLogo : StripeEntity<PaymentMethodCustomLogo>
    {
        /// <summary>
        /// Content type of the Dashboard-only CustomPaymentMethodType logo.
        /// </summary>
        [JsonProperty("content_type")]
        [STJS.JsonPropertyName("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// URL of the Dashboard-only CustomPaymentMethodType logo.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
