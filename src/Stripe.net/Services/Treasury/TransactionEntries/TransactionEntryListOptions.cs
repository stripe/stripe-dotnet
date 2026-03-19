// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TransactionEntryListOptions : ListOptions
    {
        /// <summary>
        /// Only return TransactionEntries that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        [JsonProperty("effective_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("effective_at")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> EffectiveAt { get; set; }

        /// <summary>
        /// Returns objects associated with this FinancialAccount.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// The results are in reverse chronological order by <c>created</c> or <c>effective_at</c>.
        /// The default is <c>created</c>.
        /// One of: <c>created</c>, or <c>effective_at</c>.
        /// </summary>
        [JsonProperty("order_by")]
        [STJS.JsonPropertyName("order_by")]
        public string OrderBy { get; set; }

        /// <summary>
        /// Only return TransactionEntries associated with this Transaction.
        /// </summary>
        [JsonProperty("transaction")]
        [STJS.JsonPropertyName("transaction")]
        public string Transaction { get; set; }
    }
}
