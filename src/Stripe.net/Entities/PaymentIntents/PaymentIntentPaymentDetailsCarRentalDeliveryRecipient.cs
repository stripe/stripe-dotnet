// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentDetailsCarRentalDeliveryRecipient : StripeEntity<PaymentIntentPaymentDetailsCarRentalDeliveryRecipient>
    {
        /// <summary>
        /// The email of the recipient the ticket is delivered to.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The name of the recipient the ticket is delivered to.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The phone number of the recipient the ticket is delivered to.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
