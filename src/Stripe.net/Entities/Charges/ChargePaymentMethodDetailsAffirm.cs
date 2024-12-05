// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsAffirm : StripeEntity<ChargePaymentMethodDetailsAffirm>
    {
        /// <summary>
        /// The Affirm transaction ID associated with this payment.
        /// </summary>
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }
    }
}
