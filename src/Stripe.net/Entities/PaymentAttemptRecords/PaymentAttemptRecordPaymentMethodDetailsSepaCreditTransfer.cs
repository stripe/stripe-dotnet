// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentAttemptRecordPaymentMethodDetailsSepaCreditTransfer : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsSepaCreditTransfer>
    {
        /// <summary>
        /// Name of the bank associated with the bank account.
        /// </summary>
        [JsonProperty("bank_name")]
        [STJS.JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// Bank Identifier Code of the bank associated with the bank account.
        /// </summary>
        [JsonProperty("bic")]
        [STJS.JsonPropertyName("bic")]
        public string Bic { get; set; }

        /// <summary>
        /// IBAN of the bank account to transfer funds to.
        /// </summary>
        [JsonProperty("iban")]
        [STJS.JsonPropertyName("iban")]
        public string Iban { get; set; }
    }
}
