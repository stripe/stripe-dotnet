// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// TransactionEntries represent individual money movements across different states within a
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
        /// The delta to the FinancialAccount's balance.
        /// </summary>
        [JsonProperty("balance_impact")]
        [STJS.JsonPropertyName("balance_impact")]
        public TransactionEntryBalanceImpact BalanceImpact { get; set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the entry impacted (or will impact if it's in the future) the
        /// FinancialAccount balance.
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
        /// The Transaction that this TransactionEntry belongs to.
        /// </summary>
        [JsonProperty("transaction")]
        [STJS.JsonPropertyName("transaction")]
        public string Transaction { get; set; }

        /// <summary>
        /// Details copied from the transaction that this TransactionEntry belongs to.
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
