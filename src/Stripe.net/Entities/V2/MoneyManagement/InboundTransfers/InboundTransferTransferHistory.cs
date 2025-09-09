// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InboundTransferTransferHistory : StripeEntity<InboundTransferTransferHistory>, IHasId
    {
        /// <summary>
        /// Creation time of the HistoryEntry in RFC 3339 format and UTC.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Effective at time of the HistoryEntry in RFC 3339 format and UTC.
        /// </summary>
        [JsonProperty("effective_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("effective_at")]
#endif
        public DateTime EffectiveAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A unique ID for the HistoryEntry.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// Open Enum. The Level of the HistoryEntry.
        /// One of: <c>canonical</c>, or <c>debug</c>.
        /// </summary>
        [JsonProperty("level")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("level")]
#endif
        public string Level { get; set; }

        /// <summary>
        /// Open Enum. The type of the HistoryEntry.
        /// One of: <c>bank_debit_failed</c>, <c>bank_debit_processing</c>,
        /// <c>bank_debit_queued</c>, <c>bank_debit_returned</c>, or <c>bank_debit_succeeded</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The history entry for a failed InboundTransfer.
        /// </summary>
        [JsonProperty("bank_debit_failed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_debit_failed")]
#endif
        public InboundTransferTransferHistoryBankDebitFailed BankDebitFailed { get; set; }

        /// <summary>
        /// The history entry for a processing InboundTransfer.
        /// </summary>
        [JsonProperty("bank_debit_processing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_debit_processing")]
#endif
        public Dictionary<string, object> BankDebitProcessing { get; set; }

        /// <summary>
        /// The history entry for a queued InboundTransfer.
        /// </summary>
        [JsonProperty("bank_debit_queued")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_debit_queued")]
#endif
        public Dictionary<string, object> BankDebitQueued { get; set; }

        /// <summary>
        /// The history entry for a returned InboundTransfer.
        /// </summary>
        [JsonProperty("bank_debit_returned")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_debit_returned")]
#endif
        public InboundTransferTransferHistoryBankDebitReturned BankDebitReturned { get; set; }

        /// <summary>
        /// The history entry for a succeeded InboundTransfer.
        /// </summary>
        [JsonProperty("bank_debit_succeeded")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_debit_succeeded")]
#endif
        public Dictionary<string, object> BankDebitSucceeded { get; set; }
    }
}
