// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OnrampSessionTransactionDetails : StripeEntity<OnrampSessionTransactionDetails>
    {
        /// <summary>
        /// The amount of crypto the customer will get deposited into their wallet.
        /// </summary>
        [JsonProperty("destination_amount")]
        [STJS.JsonPropertyName("destination_amount")]
        public string DestinationAmount { get; set; }

        /// <summary>
        /// If a platform wants to lock the currencies an session will support, they can add
        /// supported currencies to this array. If left null, the experience will allow selection of
        /// all supported destination currencies.
        /// One of: <c>avax</c>, <c>btc</c>, <c>eth</c>, <c>matic</c>, <c>sol</c>, <c>usdc</c>,
        /// <c>wld</c>, or <c>xlm</c>.
        /// </summary>
        [JsonProperty("destination_currencies")]
        [STJS.JsonPropertyName("destination_currencies")]
        public List<string> DestinationCurrencies { get; set; }

        /// <summary>
        /// The selected <c>destination_currency</c> to convert the <c>source</c> to. This should be
        /// a crypto currency code. If <c>destination_currencies</c> is set, it must be a value in
        /// that array.
        /// One of: <c>avax</c>, <c>btc</c>, <c>eth</c>, <c>matic</c>, <c>sol</c>, <c>usdc</c>,
        /// <c>wld</c>, or <c>xlm</c>.
        /// </summary>
        [JsonProperty("destination_currency")]
        [STJS.JsonPropertyName("destination_currency")]
        public string DestinationCurrency { get; set; }

        /// <summary>
        /// The specific crypto network the <c>destination_currency</c> is settled on. If
        /// <c>destination_networks</c> is set, it must be a value in that array.
        /// One of: <c>avalanche</c>, <c>base</c>, <c>bitcoin</c>, <c>ethereum</c>, <c>optimism</c>,
        /// <c>polygon</c>, <c>solana</c>, <c>stellar</c>, or <c>worldchain</c>.
        /// </summary>
        [JsonProperty("destination_network")]
        [STJS.JsonPropertyName("destination_network")]
        public string DestinationNetwork { get; set; }

        /// <summary>
        /// If a platform wants to lock the supported networks, they can do so through this array.
        /// If left null, the experience will allow selection of all supported networks.
        /// One of: <c>avalanche</c>, <c>base</c>, <c>bitcoin</c>, <c>ethereum</c>, <c>optimism</c>,
        /// <c>polygon</c>, <c>solana</c>, <c>stellar</c>, or <c>worldchain</c>.
        /// </summary>
        [JsonProperty("destination_networks")]
        [STJS.JsonPropertyName("destination_networks")]
        public List<string> DestinationNetworks { get; set; }

        /// <summary>
        /// Details about the fees associated with this transaction.
        /// </summary>
        [JsonProperty("fees")]
        [STJS.JsonPropertyName("fees")]
        public OnrampSessionTransactionDetailsFees Fees { get; set; }

        /// <summary>
        /// Whether or not to lock the suggested wallet address.
        /// </summary>
        [JsonProperty("lock_wallet_address")]
        [STJS.JsonPropertyName("lock_wallet_address")]
        public bool? LockWalletAddress { get; set; }

        /// <summary>
        /// Speed at which the cryptocurrency is delivered to the wallet One of: <c>instant</c>
        /// (default): crypto is delivered when payment is confirmed <c>standard</c>: crypto is
        /// delivered when payment settles.
        /// One of: <c>instant</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("settlement_speed")]
        [STJS.JsonPropertyName("settlement_speed")]
        public string SettlementSpeed { get; set; }

        /// <summary>
        /// The amount of fiat we intend to onramp - excluding fees.
        /// </summary>
        [JsonProperty("source_amount")]
        [STJS.JsonPropertyName("source_amount")]
        public string SourceAmount { get; set; }

        /// <summary>
        /// A fiat currency code.
        /// One of: <c>eur</c>, <c>gbp</c>, or <c>usd</c>.
        /// </summary>
        [JsonProperty("source_currency")]
        [STJS.JsonPropertyName("source_currency")]
        public string SourceCurrency { get; set; }

        /// <summary>
        /// The on-chain transaction hash (also referred to as transaction ID or tx_hash) of the
        /// transaction that was sent to the customer's wallet. The format varies by chain (e.g.
        /// <c>0xc257...1a95</c> on Ethereum, <c>5UB1...v3xZ</c> on Solana, or <c>a1b2...bf00</c> on
        /// Bitcoin). This will only be set if the session reaches
        /// <c>status=fulfillment_complete</c> and we've transferred the crypto successfully to the
        /// external wallet.
        /// </summary>
        [JsonProperty("transaction_id")]
        [STJS.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// The consumer's wallet address (where crypto will be sent to).
        /// </summary>
        [JsonProperty("wallet_address")]
        [STJS.JsonPropertyName("wallet_address")]
        public string WalletAddress { get; set; }

        /// <summary>
        /// The end customer's crypto wallet address (for each network) to use for this transaction.
        /// </summary>
        [JsonProperty("wallet_addresses")]
        [STJS.JsonPropertyName("wallet_addresses")]
        public OnrampSessionTransactionDetailsWalletAddresses WalletAddresses { get; set; }
    }
}
