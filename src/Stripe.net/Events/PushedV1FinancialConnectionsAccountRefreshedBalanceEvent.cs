// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when an Account’s <c>balance_refresh</c> status transitions from <c>pending</c>
    /// to either <c>succeeded</c> or <c>failed</c>.
    /// </summary>
    public class PushedV1FinancialConnectionsAccountRefreshedBalanceEvent : V2.PushedEvent
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.EventRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<FinancialConnections.Account> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<FinancialConnections.Account>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public FinancialConnections.Account FetchRelatedObject()
        {
            return this.FetchRelatedObject<FinancialConnections.Account>(this.RelatedObject);
        }

        public V1FinancialConnectionsAccountRefreshedBalanceEvent Pull()
        {
            return this.PullEvent<V1FinancialConnectionsAccountRefreshedBalanceEvent>();
        }

        public Task<V1FinancialConnectionsAccountRefreshedBalanceEvent> PullAsync()
        {
            return this.PullEventAsync<V1FinancialConnectionsAccountRefreshedBalanceEvent>();
        }
    }
}
