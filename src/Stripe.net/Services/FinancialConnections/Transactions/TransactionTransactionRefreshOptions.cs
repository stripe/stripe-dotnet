// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TransactionTransactionRefreshOptions : INestedOptions
    {
        /// <summary>
        /// Return results where the transactions were created or updated by a refresh that took
        /// place after this refresh (non-inclusive).
        /// </summary>
        [JsonProperty("after")]
        [STJS.JsonPropertyName("after")]
        public string After { get; set; }
    }
}
