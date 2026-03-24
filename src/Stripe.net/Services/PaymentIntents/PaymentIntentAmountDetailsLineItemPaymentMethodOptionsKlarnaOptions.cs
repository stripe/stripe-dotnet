// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentAmountDetailsLineItemPaymentMethodOptionsKlarnaOptions : INestedOptions
    {
        /// <summary>
        /// URL to an image for the product. Max length, 4096 characters.
        /// </summary>
        [JsonProperty("image_url")]
        [STJS.JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// URL to the product page. Max length, 4096 characters.
        /// </summary>
        [JsonProperty("product_url")]
        [STJS.JsonPropertyName("product_url")]
        public string ProductUrl { get; set; }

        /// <summary>
        /// Unique reference for this line item to correlate it with your system’s internal records.
        /// The field is displayed in the Klarna Consumer App if passed.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Reference for the subscription this line item is for.
        /// </summary>
        [JsonProperty("subscription_reference")]
        [STJS.JsonPropertyName("subscription_reference")]
        public string SubscriptionReference { get; set; }
    }
}
