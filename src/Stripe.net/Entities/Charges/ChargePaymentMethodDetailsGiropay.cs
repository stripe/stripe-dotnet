namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsGiropay : StripeEntity<ChargePaymentMethodDetailsGiropay>
    {
        /// <summary>
        /// Bank code of bank associated with the bank account.
        /// </summary>
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// Name of the bank associated with the bank account.
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// Bank Identifier Code of the bank associated with the bank account.
        /// </summary>
        [JsonProperty("bic")]
        public string Bic { get; set; }

        /// <summary>
        /// Owner's verified full name. Values are verified or provided by Giropay directly (if
        /// supported) at the time of authorization or settlement. They cannot be set or mutated.
        /// Giropay rarely provides this information so the attribute is usually empty.
        /// </summary>
        [JsonProperty("verified_name")]
        public string VerifiedName { get; set; }
    }
}
