// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentRecordPaymentMethodDetailsBillingDetails : StripeEntity<PaymentRecordPaymentMethodDetailsBillingDetails>
    {
        /// <summary>
        /// Address data.
        /// </summary>
        [JsonProperty("address")]
        public PaymentRecordPaymentMethodDetailsBillingDetailsAddress Address { get; set; }

        /// <summary>
        /// The billing email associated with the method of payment.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The billing name associated with the method of payment.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The billing phone number associated with the method of payment.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
