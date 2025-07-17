// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentAmountDetailsLineItemPaymentMethodOptionsKlarnaOptions : INestedOptions
    {
        /// <summary>
        /// URL to an image for the product. Max length, 4096 characters.
        /// </summary>
        [JsonProperty("image_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("image_url")]
#endif
        public string ImageUrl { get; set; }

        /// <summary>
        /// URL to the product page. Max length, 4096 characters.
        /// </summary>
        [JsonProperty("product_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product_url")]
#endif
        public string ProductUrl { get; set; }

        /// <summary>
        /// Reference for the subscription this line item is for.
        /// </summary>
        [JsonProperty("subscription_reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_reference")]
#endif
        public string SubscriptionReference { get; set; }
    }
}
