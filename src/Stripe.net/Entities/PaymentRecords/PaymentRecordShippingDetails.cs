// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentRecordShippingDetails : StripeEntity<PaymentRecordShippingDetails>
    {
        /// <summary>
        /// Address data.
        /// </summary>
        [JsonProperty("address")]
        public PaymentRecordShippingDetailsAddress Address { get; set; }

        /// <summary>
        /// The recipient's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The recipient's phone number.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
