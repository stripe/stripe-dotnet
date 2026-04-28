// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAddressCreateOptions : BaseOptions
    {
        /// <summary>
        /// Properties needed to create a FinancialAddress for an FA with USDC currency.
        /// </summary>
        [JsonProperty("crypto_properties")]
        [STJS.JsonPropertyName("crypto_properties")]
        public FinancialAddressCreateCryptoPropertiesOptions CryptoProperties { get; set; }

        /// <summary>
        /// The ID of the FinancialAccount the new FinancialAddress should be associated with.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Optional SEPA Bank account options, used to configure the type of SEPA Bank account to
        /// create, such as the originating country.
        /// </summary>
        [JsonProperty("sepa_bank_account")]
        [STJS.JsonPropertyName("sepa_bank_account")]
        public FinancialAddressCreateSepaBankAccountOptions SepaBankAccount { get; set; }

        /// <summary>
        /// Open Enum. The currency the FinancialAddress settles into the FinancialAccount.
        /// Currently, only the <c>usd</c>, <c>gbp</c> and <c>usdc</c> values are supported.
        /// </summary>
        [JsonProperty("settlement_currency")]
        [STJS.JsonPropertyName("settlement_currency")]
        public string SettlementCurrency { get; set; }

        /// <summary>
        /// The type of FinancialAddress details to provision.
        /// One of: <c>ca_bank_account</c>, <c>crypto_wallet</c>, <c>gb_bank_account</c>,
        /// <c>mx_bank_account</c>, <c>sepa_bank_account</c>, or <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
