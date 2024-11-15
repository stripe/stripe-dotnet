// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionTransactionRefreshOptions : INestedOptions
    {
        /// <summary>
        /// Return results where the transactions were created or updated by a refresh that took
        /// place after this refresh (non-inclusive).
        /// </summary>
        [JsonProperty("after")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("after")]
#endif

        public string After { get; set; }
    }
}
