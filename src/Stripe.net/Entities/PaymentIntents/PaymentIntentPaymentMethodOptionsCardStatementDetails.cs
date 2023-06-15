// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsCardStatementDetails : StripeEntity<PaymentIntentPaymentMethodOptionsCardStatementDetails>
    {
        [JsonProperty("address")]
        public PaymentIntentPaymentMethodOptionsCardStatementDetailsAddress Address { get; set; }

        /// <summary>
        /// Phone number.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
