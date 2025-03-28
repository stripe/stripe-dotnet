// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionEntryListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter for Transactions created after the specified timestamp.
        /// </summary>
        [JsonProperty("created_gt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created_gt")]
#endif
        public DateTime? CreatedGt { get; set; }

        /// <summary>
        /// Filter for Transactions created at or after the specified timestamp.
        /// </summary>
        [JsonProperty("created_gte")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created_gte")]
#endif
        public DateTime? CreatedGte { get; set; }

        /// <summary>
        /// Filter for Transactions created before the specified timestamp.
        /// </summary>
        [JsonProperty("created_lt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created_lt")]
#endif
        public DateTime? CreatedLt { get; set; }

        /// <summary>
        /// Filter for Transactions created at or before the specified timestamp.
        /// </summary>
        [JsonProperty("created_lte")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created_lte")]
#endif
        public DateTime? CreatedLte { get; set; }

        /// <summary>
        /// Filter for TransactionEntries belonging to a Transaction.
        /// </summary>
        [JsonProperty("transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction")]
#endif
        public string Transaction { get; set; }
    }
}
