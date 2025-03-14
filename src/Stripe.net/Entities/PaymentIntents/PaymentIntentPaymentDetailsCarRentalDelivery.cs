// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsCarRentalDelivery : StripeEntity<PaymentIntentPaymentDetailsCarRentalDelivery>
    {
        /// <summary>
        /// The delivery method for the payment.
        /// One of: <c>email</c>, <c>phone</c>, <c>pickup</c>, or <c>post</c>.
        /// </summary>
        [JsonProperty("mode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mode")]
#endif
        public string Mode { get; set; }

        [JsonProperty("recipient")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recipient")]
#endif
        public PaymentIntentPaymentDetailsCarRentalDeliveryRecipient Recipient { get; set; }
    }
}
