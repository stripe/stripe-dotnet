// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedCreditCryptoWalletTransfer : StripeEntity<ReceivedCreditCryptoWalletTransfer>
    {
        /// <summary>
        /// Hash containing the transaction crypto wallet details.
        /// </summary>
        [JsonProperty("crypto_wallet")]
        [STJS.JsonPropertyName("crypto_wallet")]
        public ReceivedCreditCryptoWalletTransferCryptoWallet CryptoWallet { get; set; }

        /// <summary>
        /// Financial Address on which funds for ReceivedCredit were received.
        /// </summary>
        [JsonProperty("financial_address")]
        [STJS.JsonPropertyName("financial_address")]
        public string FinancialAddress { get; set; }

        /// <summary>
        /// Hash containing details about the crypto wallet that originated this ReceivedCredit.
        /// </summary>
        [JsonProperty("originating_crypto_wallet")]
        [STJS.JsonPropertyName("originating_crypto_wallet")]
        public ReceivedCreditCryptoWalletTransferOriginatingCryptoWallet OriginatingCryptoWallet { get; set; }

        /// <summary>
        /// Freeform string set by originator of the external ReceivedCredit.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Open Enum. The currency of the crypto tokens received.
        /// One of: <c>btc</c>, <c>cash</c>, <c>eth</c>, <c>ousd</c>, <c>sol</c>, <c>usdc</c>,
        /// <c>usdg</c>, <c>usdsui</c>, or <c>usdt</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("token_currency")]
        [STJS.JsonPropertyName("token_currency")]
        public string TokenCurrency { get; set; }

        /// <summary>
        /// Hash of the deposit transaction on-chain (incoming to Stripe).
        /// </summary>
        [JsonProperty("transaction_hash")]
        [STJS.JsonPropertyName("transaction_hash")]
        public string TransactionHash { get; set; }

        /// <summary>
        /// Open Enum. The type of crypto wallet transfer that originated this ReceivedCredit.
        /// One of: <c>crypto_wallet</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
