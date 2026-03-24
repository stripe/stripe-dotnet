// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundTransferTransferHistory : StripeEntity<InboundTransferTransferHistory>, IHasId
    {
        /// <summary>
        /// Creation time of the HistoryEntry in RFC 3339 format and UTC.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Effective at time of the HistoryEntry in RFC 3339 format and UTC.
        /// </summary>
        [JsonProperty("effective_at")]
        [STJS.JsonPropertyName("effective_at")]
        public DateTime EffectiveAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A unique ID for the HistoryEntry.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Open Enum. The Level of the HistoryEntry.
        /// One of: <c>canonical</c>, or <c>debug</c>.
        /// </summary>
        [JsonProperty("level")]
        [STJS.JsonPropertyName("level")]
        public string Level { get; set; }

        /// <summary>
        /// Open Enum. The type of the HistoryEntry.
        /// One of: <c>bank_debit_failed</c>, <c>bank_debit_processing</c>,
        /// <c>bank_debit_queued</c>, <c>bank_debit_returned</c>, or <c>bank_debit_succeeded</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The history entry for a failed InboundTransfer.
        /// </summary>
        [JsonProperty("bank_debit_failed")]
        [STJS.JsonPropertyName("bank_debit_failed")]
        public InboundTransferTransferHistoryBankDebitFailed BankDebitFailed { get; set; }

        /// <summary>
        /// The history entry for a processing InboundTransfer.
        /// </summary>
        [JsonProperty("bank_debit_processing")]
        [STJS.JsonPropertyName("bank_debit_processing")]
        public Dictionary<string, object> BankDebitProcessing { get; set; }

        /// <summary>
        /// The history entry for a queued InboundTransfer.
        /// </summary>
        [JsonProperty("bank_debit_queued")]
        [STJS.JsonPropertyName("bank_debit_queued")]
        public Dictionary<string, object> BankDebitQueued { get; set; }

        /// <summary>
        /// The history entry for a returned InboundTransfer.
        /// </summary>
        [JsonProperty("bank_debit_returned")]
        [STJS.JsonPropertyName("bank_debit_returned")]
        public InboundTransferTransferHistoryBankDebitReturned BankDebitReturned { get; set; }

        /// <summary>
        /// The history entry for a succeeded InboundTransfer.
        /// </summary>
        [JsonProperty("bank_debit_succeeded")]
        [STJS.JsonPropertyName("bank_debit_succeeded")]
        public Dictionary<string, object> BankDebitSucceeded { get; set; }
    }
}
