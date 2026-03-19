// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TransactionListOptions : ListOptions
    {
        /// <summary>
        /// Only return Transactions that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Returns objects associated with this FinancialAccount.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// The results are in reverse chronological order by <c>created</c> or <c>posted_at</c>.
        /// The default is <c>created</c>.
        /// One of: <c>created</c>, or <c>posted_at</c>.
        /// </summary>
        [JsonProperty("order_by")]
        [STJS.JsonPropertyName("order_by")]
        public string OrderBy { get; set; }

        /// <summary>
        /// Only return Transactions that have the given status: <c>open</c>, <c>posted</c>, or
        /// <c>void</c>.
        /// One of: <c>open</c>, <c>posted</c>, or <c>void</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// A filter for the <c>status_transitions.posted_at</c> timestamp. When using this filter,
        /// <c>status=posted</c> and <c>order_by=posted_at</c> must also be specified.
        /// </summary>
        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public TransactionStatusTransitionsOptions StatusTransitions { get; set; }
    }
}
