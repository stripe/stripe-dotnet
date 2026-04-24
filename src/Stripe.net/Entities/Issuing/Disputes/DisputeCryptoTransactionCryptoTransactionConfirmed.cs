// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DisputeCryptoTransactionCryptoTransactionConfirmed : StripeEntity<DisputeCryptoTransactionCryptoTransactionConfirmed>
    {
        /// <summary>
        /// The crypto amount for the confirmed transaction.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// The upcharged MCC amount, if one was applied.
        /// </summary>
        [JsonProperty("amount_mcc_upcharged")]
        [STJS.JsonPropertyName("amount_mcc_upcharged")]
        public string AmountMccUpcharged { get; set; }

        /// <summary>
        /// The blockchain network for the confirmed transaction.
        /// </summary>
        [JsonProperty("chain")]
        [STJS.JsonPropertyName("chain")]
        public string Chain { get; set; }

        /// <summary>
        /// When the transaction was confirmed onchain.
        /// </summary>
        [JsonProperty("confirmed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("confirmed_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ConfirmedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The currency of the crypto transaction amount.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Fees associated with the transaction.
        /// </summary>
        [JsonProperty("fees")]
        [STJS.JsonPropertyName("fees")]
        public List<DisputeCryptoTransactionCryptoTransactionConfirmedFee> Fees { get; set; }

        /// <summary>
        /// The source wallet address for the transaction.
        /// </summary>
        [JsonProperty("from_address")]
        [STJS.JsonPropertyName("from_address")]
        public string FromAddress { get; set; }

        /// <summary>
        /// Memo metadata attached to the transaction, if present.
        /// </summary>
        [JsonProperty("memo")]
        [STJS.JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// The destination wallet address for the transaction.
        /// </summary>
        [JsonProperty("to_address")]
        [STJS.JsonPropertyName("to_address")]
        public string ToAddress { get; set; }

        /// <summary>
        /// The blockchain transaction hash.
        /// </summary>
        [JsonProperty("transaction_hash")]
        [STJS.JsonPropertyName("transaction_hash")]
        public string TransactionHash { get; set; }
    }
}
