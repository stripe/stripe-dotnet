// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAddressCredentials : StripeEntity<FinancialAddressCredentials>
    {
        /// <summary>
        /// The credentials of the Canadian Bank Account for the FinancialAddress. This contains
        /// unique banking details such as the account number, institution number, etc. of a
        /// Canadian bank account.
        /// </summary>
        [JsonProperty("ca_bank_account")]
        [STJS.JsonPropertyName("ca_bank_account")]
        public FinancialAddressCredentialsCaBankAccount CaBankAccount { get; set; }

        /// <summary>
        /// The credentials of the crypto wallet for the Financial Address. This contains unique
        /// details such as the blockchain network, wallet address, and memo of a crypto wallet.
        /// </summary>
        [JsonProperty("crypto_wallet")]
        [STJS.JsonPropertyName("crypto_wallet")]
        public FinancialAddressCredentialsCryptoWallet CryptoWallet { get; set; }

        /// <summary>
        /// The credentials of the UK Bank Account for the FinancialAddress. This contains unique
        /// banking details such as the sort code, account number, etc. of a UK bank account.
        /// </summary>
        [JsonProperty("gb_bank_account")]
        [STJS.JsonPropertyName("gb_bank_account")]
        public FinancialAddressCredentialsGbBankAccount GbBankAccount { get; set; }

        /// <summary>
        /// The credentials of the Mexican Bank Account for the FinancialAddress. This contains
        /// unique banking details such as the CLABE and account holder name of a Mexican bank
        /// account.
        /// </summary>
        [JsonProperty("mx_bank_account")]
        [STJS.JsonPropertyName("mx_bank_account")]
        public FinancialAddressCredentialsMxBankAccount MxBankAccount { get; set; }

        /// <summary>
        /// The credentials of the SEPA Bank Account for the FinancialAddress. This contains unique
        /// banking details such as the IBAN, BIC, etc. of a SEPA bank account.
        /// </summary>
        [JsonProperty("sepa_bank_account")]
        [STJS.JsonPropertyName("sepa_bank_account")]
        public FinancialAddressCredentialsSepaBankAccount SepaBankAccount { get; set; }

        /// <summary>
        /// Open Enum. The type of Credentials that are provisioned for the FinancialAddress.
        /// One of: <c>ca_bank_account</c>, <c>crypto_wallet</c>, <c>gb_bank_account</c>,
        /// <c>mx_bank_account</c>, <c>sepa_bank_account</c>, or <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The credentials of the US Bank Account for the FinancialAddress. This contains unique
        /// banking details such as the routing number, account number, etc. of a US bank account.
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public FinancialAddressCredentialsUsBankAccount UsBankAccount { get; set; }
    }
}
