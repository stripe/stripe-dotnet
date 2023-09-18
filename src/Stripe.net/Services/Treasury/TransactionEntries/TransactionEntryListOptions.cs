// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TransactionEntryListOptions : ListOptionsWithCreated
    {
        [JsonProperty("effective_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> EffectiveAt { get; set; }

        /// <summary>
        /// Returns objects associated with this FinancialAccount.
        /// </summary>
        [JsonProperty("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// The results are in reverse chronological order by <c>created</c> or <c>effective_at</c>.
        /// The default is <c>created</c>.
        /// One of: <c>created</c>, or <c>effective_at</c>.
        /// </summary>
        [JsonProperty("order_by")]
        public string OrderBy { get; set; }

        /// <summary>
        /// Only return TransactionEntries associated with this Transaction.
        /// </summary>
        [JsonProperty("transaction")]
        public string Transaction { get; set; }
    }
}
