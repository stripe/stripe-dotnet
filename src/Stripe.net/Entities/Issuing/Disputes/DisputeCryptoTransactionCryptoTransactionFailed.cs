// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DisputeCryptoTransactionCryptoTransactionFailed : StripeEntity<DisputeCryptoTransactionCryptoTransactionFailed>
    {
        /// <summary>
        /// The crypto amount for the failed transaction.
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
        /// The blockchain network for the failed transaction.
        /// </summary>
        [JsonProperty("chain")]
        [STJS.JsonPropertyName("chain")]
        public string Chain { get; set; }

        /// <summary>
        /// The currency of the crypto transaction amount.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// When the transaction failed.
        /// </summary>
        [JsonProperty("failed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("failed_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime FailedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The reason the transaction failed.
        /// </summary>
        [JsonProperty("failure_reason")]
        [STJS.JsonPropertyName("failure_reason")]
        public string FailureReason { get; set; }

        /// <summary>
        /// Fees associated with the transaction.
        /// </summary>
        [JsonProperty("fees")]
        [STJS.JsonPropertyName("fees")]
        public List<DisputeCryptoTransactionCryptoTransactionFailedFee> Fees { get; set; }

        /// <summary>
        /// The source wallet address for the attempted transaction.
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
        /// The destination wallet address for the attempted transaction when one exists.
        /// </summary>
        [JsonProperty("to_address")]
        [STJS.JsonPropertyName("to_address")]
        public string ToAddress { get; set; }

        /// <summary>
        /// The blockchain transaction hash when one exists.
        /// </summary>
        [JsonProperty("transaction_hash")]
        [STJS.JsonPropertyName("transaction_hash")]
        public string TransactionHash { get; set; }
    }
}
