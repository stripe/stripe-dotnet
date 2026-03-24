// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentAttemptRecordPaymentMethodDetailsGiropay : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsGiropay>
    {
        /// <summary>
        /// Bank code of bank associated with the bank account.
        /// </summary>
        [JsonProperty("bank_code")]
        [STJS.JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

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
        /// Owner's verified full name. Values are verified or provided by Giropay directly (if
        /// supported) at the time of authorization or settlement. They cannot be set or mutated.
        /// Giropay rarely provides this information so the attribute is usually empty.
        /// </summary>
        [JsonProperty("verified_name")]
        [STJS.JsonPropertyName("verified_name")]
        public string VerifiedName { get; set; }
    }
}
