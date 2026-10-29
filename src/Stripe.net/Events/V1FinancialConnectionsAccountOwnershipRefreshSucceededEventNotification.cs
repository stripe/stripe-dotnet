// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when an ownership refresh on a Financial Connections account completes
    /// successfully.
    /// </summary>
    public class V1FinancialConnectionsAccountOwnershipRefreshSucceededEventNotification : V2.Core.EventNotification
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
        [STJS.JsonPropertyName("related_object")]
        public V2.Core.EventNotificationRelatedObject RelatedObject { get; set; }

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

        public V1FinancialConnectionsAccountOwnershipRefreshSucceededEvent FetchEvent()
        {
            return this.FetchEvent<V1FinancialConnectionsAccountOwnershipRefreshSucceededEvent>();
        }

        public Task<V1FinancialConnectionsAccountOwnershipRefreshSucceededEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1FinancialConnectionsAccountOwnershipRefreshSucceededEvent>();
        }
    }
}
