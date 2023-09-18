// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TransactionListOptions : ListOptions
    {
        /// <summary>
        /// The ID of the Stripe account whose transactions will be retrieved.
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// A filter on the list based on the object <c>transacted_at</c> field. The value can be a
        /// string with an integer Unix timestamp, or it can be a dictionary with the following
        /// options:.
        /// </summary>
        [JsonProperty("transacted_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> TransactedAt { get; set; }

        /// <summary>
        /// A filter on the list based on the object <c>transaction_refresh</c> field. The value can
        /// be a dictionary with the following options:.
        /// </summary>
        [JsonProperty("transaction_refresh")]
        public TransactionTransactionRefreshOptions TransactionRefresh { get; set; }
    }
}
