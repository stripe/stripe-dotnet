// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs whenever there is a positive remaining cash balance after Stripe automatically
    /// reconciles new funds into the cash balance. If you enabled manual reconciliation, this
    /// webhook will fire whenever there are new funds into the cash balance.
    /// </summary>
    public class V1CashBalanceFundsAvailableEventNotification : V2.Core.EventNotification
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
        public Task<CashBalance> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<CashBalance>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public CashBalance FetchRelatedObject()
        {
            return this.FetchRelatedObject<CashBalance>(this.RelatedObject);
        }

        public V1CashBalanceFundsAvailableEvent FetchEvent()
        {
            return this.FetchEvent<V1CashBalanceFundsAvailableEvent>();
        }

        public Task<V1CashBalanceFundsAvailableEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1CashBalanceFundsAvailableEvent>();
        }
    }
}
