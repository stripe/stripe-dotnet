// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentDetailsLodgingDeliveryOptions : INestedOptions
    {
        /// <summary>
        /// The delivery method for the payment.
        /// One of: <c>email</c>, <c>phone</c>, <c>pickup</c>, or <c>post</c>.
        /// </summary>
        [JsonProperty("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Details of the recipient.
        /// </summary>
        [JsonProperty("recipient")]
        public PaymentIntentPaymentDetailsLodgingDeliveryRecipientOptions Recipient { get; set; }
    }
}
