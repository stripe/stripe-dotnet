namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsBancontact : StripeEntity<ChargePaymentMethodDetailsBancontact>
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
        /// Last four characters of the IBAN.
        /// </summary>
        [JsonProperty("iban_last4")]
        public string IbanLast4 { get; set; }

        /// <summary>
        /// Preferred language of the Bancontact authorization page that the customer is redirected
        /// to. Can be one of <c>en</c>, <c>de</c>, <c>fr</c>, or <c>nl</c>.
        /// One of: <c>de</c>, <c>en</c>, <c>fr</c>, or <c>nl</c>.
        /// </summary>
        [JsonProperty("preferred_language")]
        public string PreferredLanguage { get; set; }

        /// <summary>
        /// Owner's verified full name. Values are verified or provided by Bancontact directly (if
        /// supported) at the time of authorization or settlement. They cannot be set or mutated.
        /// </summary>
        [JsonProperty("verified_name")]
        public string VerifiedName { get; set; }
    }
}
