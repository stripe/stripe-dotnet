// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsSwish : StripeEntity<ChargePaymentMethodDetailsSwish>
    {
        /// <summary>
        /// Uniquely identifies the payer's Swish account. You can use this attribute to check
        /// whether two Swish transactions were paid for by the same payer.
        /// </summary>
        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Payer bank reference number for the payment.
        /// </summary>
        [JsonProperty("payment_reference")]
        public string PaymentReference { get; set; }

        /// <summary>
        /// The last four digits of the Swish account phone number.
        /// </summary>
        [JsonProperty("verified_phone_last4")]
        public string VerifiedPhoneLast4 { get; set; }
    }
}
