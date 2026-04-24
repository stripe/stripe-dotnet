// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs whenever a new customer cash balance transactions is created.
    /// </summary>
    public class V1CustomerCashBalanceTransactionCreatedEventNotification : V2.Core.EventNotification
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
        public Task<CustomerCashBalanceTransaction> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<CustomerCashBalanceTransaction>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public CustomerCashBalanceTransaction FetchRelatedObject()
        {
            return this.FetchRelatedObject<CustomerCashBalanceTransaction>(this.RelatedObject);
        }

        public V1CustomerCashBalanceTransactionCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V1CustomerCashBalanceTransactionCreatedEvent>();
        }

        public Task<V1CustomerCashBalanceTransactionCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1CustomerCashBalanceTransactionCreatedEvent>();
        }
    }
}
