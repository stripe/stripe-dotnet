// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedCreditCryptoWalletTransfer : StripeEntity<ReceivedCreditCryptoWalletTransfer>
    {
        /// <summary>
        /// Hash containing the transaction crypto wallet details.
        /// </summary>
        [JsonProperty("crypto_wallet")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("crypto_wallet")]
#endif
        public ReceivedCreditCryptoWalletTransferCryptoWallet CryptoWallet { get; set; }

        /// <summary>
        /// Financial Address on which funds for ReceivedCredit were received.
        /// </summary>
        [JsonProperty("financial_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_address")]
#endif
        public string FinancialAddress { get; set; }

        /// <summary>
        /// Open Enum. Indicates the type of source via from which external funds originated.
        /// One of: <c>crypto_wallet</c>, <c>eu_bank_account</c>, <c>gb_bank_account</c>, or
        /// <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("payment_method_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_type")]
#endif
        public string PaymentMethodType { get; set; }

        /// <summary>
        /// Freeform string set by originator of the external ReceivedCredit.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }
    }
}
