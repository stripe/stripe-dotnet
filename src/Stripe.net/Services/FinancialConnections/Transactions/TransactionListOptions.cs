// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TransactionListOptions : ListOptions
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("transacted_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> TransactedAt { get; set; }

        [JsonProperty("transaction_refresh")]
        public TransactionTransactionRefreshOptions TransactionRefresh { get; set; }
    }
}
