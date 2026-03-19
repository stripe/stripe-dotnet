// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentAmountDetailsLineItemPaymentMethodOptionsKlarna : StripeEntity<PaymentIntentAmountDetailsLineItemPaymentMethodOptionsKlarna>
    {
        [JsonProperty("image_url")]
        [STJS.JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("product_url")]
        [STJS.JsonPropertyName("product_url")]
        public string ProductUrl { get; set; }

        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonProperty("subscription_reference")]
        [STJS.JsonPropertyName("subscription_reference")]
        public string SubscriptionReference { get; set; }
    }
}
