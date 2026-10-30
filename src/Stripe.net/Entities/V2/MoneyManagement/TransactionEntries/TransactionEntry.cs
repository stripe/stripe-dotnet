// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// TransactionEntries model funds moving between availability states for a given
    /// Transaction.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionEntry : StripeEntity<TransactionEntry>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The change to the FinancialAccount's balance that takes effect at this
        /// TransactionEntry's <c>effective_at</c> timestamp.
        /// </summary>
        [JsonProperty("balance_impact")]
        [STJS.JsonPropertyName("balance_impact")]
        public TransactionEntryBalanceImpact BalanceImpact { get; set; }

        /// <summary>
        /// Time at which the object was created. Represented as an RFC 3339 timestamp in UTC with
        /// millisecond precision, for example <c>2022-09-18T13:22:18.123Z</c>.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the TransactionEntry affects the FinancialAccount balance. This can be in
        /// the past or future.
        /// </summary>
        [JsonProperty("effective_at")]
        [STJS.JsonPropertyName("effective_at")]
        public DateTime EffectiveAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The ID of the Transaction that this TransactionEntry belongs to.
        /// </summary>
        [JsonProperty("transaction")]
        [STJS.JsonPropertyName("transaction")]
        public string Transaction { get; set; }

        /// <summary>
        /// Details copied from the Transaction that this TransactionEntry belongs to.
        /// </summary>
        [JsonProperty("transaction_details")]
        [STJS.JsonPropertyName("transaction_details")]
        public TransactionEntryTransactionDetails TransactionDetails { get; set; }

        /// <summary>
        /// The v1 Treasury transaction entry associated with this transaction entry.
        /// </summary>
        [JsonProperty("treasury_transaction_entry")]
        [STJS.JsonPropertyName("treasury_transaction_entry")]
        public string TreasuryTransactionEntry { get; set; }
    }
}
