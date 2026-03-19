// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ChargePaymentMethodDetailsAuBecsDebit : StripeEntity<ChargePaymentMethodDetailsAuBecsDebit>
    {
        /// <summary>
        /// Bank-State-Branch number of the bank account.
        /// </summary>
        [JsonProperty("bsb_number")]
        [STJS.JsonPropertyName("bsb_number")]
        public string BsbNumber { get; set; }

        /// <summary>
        /// Estimated date to debit the customer's bank account. A date string in YYYY-MM-DD format.
        /// </summary>
        [JsonProperty("expected_debit_date")]
        [STJS.JsonPropertyName("expected_debit_date")]
        public string ExpectedDebitDate { get; set; }

        /// <summary>
        /// Uniquely identifies this particular bank account. You can use this attribute to check
        /// whether two bank accounts are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
        [STJS.JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Last four digits of the bank account number.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// ID of the mandate used to make this payment.
        /// </summary>
        [JsonProperty("mandate")]
        [STJS.JsonPropertyName("mandate")]
        public string Mandate { get; set; }
    }
}
