// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentDetailsEventDetailsDeliveryOptions : INestedOptions
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
        [JsonProperty("receipient")]
        public ChargePaymentDetailsEventDetailsDeliveryReceipientOptions Receipient { get; set; }
    }
}
