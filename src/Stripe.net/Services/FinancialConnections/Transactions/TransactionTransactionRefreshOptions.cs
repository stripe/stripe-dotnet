// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;

    public class TransactionTransactionRefreshOptions : INestedOptions
    {
        /// <summary>
        /// Return results where the transactions were created or updated by a refresh that took
        /// place after this refresh (non-inclusive).
        /// </summary>
        [JsonProperty("after")]
        public string After { get; set; }
    }
}
