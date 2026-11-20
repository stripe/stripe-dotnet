// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RefundPaymentMethodDataOptions : INestedOptions
    {
        /// <summary>
        /// The gift card to receive the refund.
        /// </summary>
        [JsonProperty("gift_card")]
        [STJS.JsonPropertyName("gift_card")]
        public RefundPaymentMethodDataGiftCardOptions GiftCard { get; set; }

        /// <summary>
        /// The type of the PaymentMethod. An additional hash is included on the PaymentMethod with
        /// a name matching this value. It contains additional information specific to the
        /// PaymentMethod type.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
