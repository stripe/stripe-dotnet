// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentAttemptRecordShippingDetails : StripeEntity<PaymentAttemptRecordShippingDetails>
    {
        /// <summary>
        /// A representation of a physical address.
        /// </summary>
        [JsonProperty("address")]
        public PaymentAttemptRecordShippingDetailsAddress Address { get; set; }

        /// <summary>
        /// The shipping recipient's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The shipping recipient's phone number.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
