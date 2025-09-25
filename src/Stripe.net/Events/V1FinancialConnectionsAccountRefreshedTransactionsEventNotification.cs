// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when an Account’s <c>transaction_refresh</c> status transitions from
    /// <c>pending</c> to either <c>succeeded</c> or <c>failed</c>.
    /// </summary>
    public class V1FinancialConnectionsAccountRefreshedTransactionsEventNotification : V2.EventNotification
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.EventNotificationRelatedObject RelatedObject { get; set; }

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

        public V1FinancialConnectionsAccountRefreshedTransactionsEvent FetchEvent()
        {
            return this.FetchEvent<V1FinancialConnectionsAccountRefreshedTransactionsEvent>();
        }

        public Task<V1FinancialConnectionsAccountRefreshedTransactionsEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1FinancialConnectionsAccountRefreshedTransactionsEvent>();
        }
    }
}
