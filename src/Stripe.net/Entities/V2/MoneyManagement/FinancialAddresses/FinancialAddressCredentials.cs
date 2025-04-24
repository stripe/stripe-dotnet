// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAddressCredentials : StripeEntity<FinancialAddressCredentials>
    {
        /// <summary>
        /// Open Enum. The type of Credentials that are provisioned for the FinancialAddress.
        /// One of: <c>crypto_wallet</c>, <c>eu_bank_account</c>, <c>gb_bank_account</c>, or
        /// <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The credentials of the crypto wallet for the Financial Address. This contains unique
        /// details such as the blockchain network, wallet address, and memo of a crypto wallet.
        /// </summary>
        [JsonProperty("crypto_wallet")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("crypto_wallet")]
#endif
        public FinancialAddressCredentialsCryptoWallet CryptoWallet { get; set; }

        /// <summary>
        /// The credentials of the EU Bank Account for the FinancialAddress. This contains unique
        /// banking details such as the IBAN, BIC, etc. of a EU bank account.
        /// </summary>
        [JsonProperty("eu_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eu_bank_account")]
#endif
        public FinancialAddressCredentialsEuBankAccount EuBankAccount { get; set; }

        /// <summary>
        /// The credentials of the UK Bank Account for the FinancialAddress. This contains unique
        /// banking details such as the sort code, account number, etc. of a UK bank account.
        /// </summary>
        [JsonProperty("gb_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gb_bank_account")]
#endif
        public FinancialAddressCredentialsGbBankAccount GbBankAccount { get; set; }

        /// <summary>
        /// The credentials of the US Bank Account for the FinancialAddress. This contains unique
        /// banking details such as the routing number, account number, etc. of a US bank account.
        /// </summary>
        [JsonProperty("us_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_account")]
#endif
        public FinancialAddressCredentialsUsBankAccount UsBankAccount { get; set; }
    }
}
