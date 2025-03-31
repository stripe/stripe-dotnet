// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionEntryListOptions : ListOptions
    {
        /// <summary>
        /// Only return TransactionEntries that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        [JsonProperty("effective_at")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("effective_at")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> EffectiveAt { get; set; }

        /// <summary>
        /// Returns objects associated with this FinancialAccount.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public string FinancialAccount { get; set; }

        /// <summary>
        /// The results are in reverse chronological order by <c>created</c> or <c>effective_at</c>.
        /// The default is <c>created</c>.
        /// One of: <c>created</c>, or <c>effective_at</c>.
        /// </summary>
        [JsonProperty("order_by")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("order_by")]
#endif
        public string OrderBy { get; set; }

        /// <summary>
        /// Only return TransactionEntries associated with this Transaction.
        /// </summary>
        [JsonProperty("transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction")]
#endif
        public string Transaction { get; set; }
    }
}
