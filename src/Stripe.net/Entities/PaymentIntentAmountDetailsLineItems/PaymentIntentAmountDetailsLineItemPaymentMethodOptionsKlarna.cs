// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentAmountDetailsLineItemPaymentMethodOptionsKlarna : StripeEntity<PaymentIntentAmountDetailsLineItemPaymentMethodOptionsKlarna>
    {
        [JsonProperty("image_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("image_url")]
#endif
        public string ImageUrl { get; set; }

        [JsonProperty("product_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product_url")]
#endif
        public string ProductUrl { get; set; }
    }
}
