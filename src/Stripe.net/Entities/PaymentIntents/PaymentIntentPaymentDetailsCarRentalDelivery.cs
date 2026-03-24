// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsCarRentalDelivery : StripeEntity<PaymentIntentPaymentDetailsCarRentalDelivery>
    {
        /// <summary>
        /// The delivery method for the payment.
        /// One of: <c>email</c>, <c>phone</c>, <c>pickup</c>, or <c>post</c>.
        /// </summary>
        [JsonProperty("mode")]
        [STJS.JsonPropertyName("mode")]
        public string Mode { get; set; }

        [JsonProperty("recipient")]
        [STJS.JsonPropertyName("recipient")]
        public PaymentIntentPaymentDetailsCarRentalDeliveryRecipient Recipient { get; set; }
    }
}
