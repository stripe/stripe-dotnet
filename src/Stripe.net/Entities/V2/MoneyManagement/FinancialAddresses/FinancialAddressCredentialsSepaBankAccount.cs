// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAddressCredentialsSepaBankAccount : StripeEntity<FinancialAddressCredentialsSepaBankAccount>
    {
        /// <summary>
        /// The account holder name to be used during bank transfers.
        /// </summary>
        [JsonProperty("account_holder_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder_name")]
#endif
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The name of the Bank.
        /// </summary>
        [JsonProperty("bank_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_name")]
#endif
        public string BankName { get; set; }

        /// <summary>
        /// The BIC of the SEPA Bank Account.
        /// </summary>
        [JsonProperty("bic")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bic")]
#endif
        public string Bic { get; set; }

        /// <summary>
        /// The originating country of the SEPA Bank account.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// The IBAN of the SEPA Bank Account.
        /// </summary>
        [JsonProperty("iban")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("iban")]
#endif
        public string Iban { get; set; }

        /// <summary>
        /// The last four digits of the SEPA Bank Account number. This will always be returned. To
        /// view the full account number when retrieving or listing FinancialAddresses, use the
        /// <c>include</c> request parameter.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }
    }
}
