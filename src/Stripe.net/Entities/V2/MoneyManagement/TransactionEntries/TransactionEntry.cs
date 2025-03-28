// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// TransactionEntries represent individual money movements across different states within a
    /// Transaction.
    /// </summary>
    public class TransactionEntry : StripeEntity<TransactionEntry>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The delta to the FinancialAccount's balance.
        /// </summary>
        [JsonProperty("balance_impact")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balance_impact")]
#endif
        public TransactionEntryBalanceImpact BalanceImpact { get; set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the entry impacted (or will impact if it's in the future) the
        /// FinancialAccount balance.
        /// </summary>
        [JsonProperty("effective_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("effective_at")]
#endif
        public DateTime EffectiveAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The Transaction that this TransactionEntry belongs to.
        /// </summary>
        [JsonProperty("transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction")]
#endif
        public string Transaction { get; set; }

        /// <summary>
        /// Details copied from the transaction that this TransactionEntry belongs to.
        /// </summary>
        [JsonProperty("transaction_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction_details")]
#endif
        public TransactionEntryTransactionDetails TransactionDetails { get; set; }
    }
}
