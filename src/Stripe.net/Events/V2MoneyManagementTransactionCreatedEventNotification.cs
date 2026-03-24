// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// Occurs when a Transaction is created.
    /// </summary>
    public class V2MoneyManagementTransactionCreatedEventNotification : V2.Core.EventNotification
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


        public Task<V2.MoneyManagement.Transaction> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.MoneyManagement.Transaction>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>


        public V2.MoneyManagement.Transaction FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.MoneyManagement.Transaction>(this.RelatedObject);
        }

        public V2MoneyManagementTransactionCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V2MoneyManagementTransactionCreatedEvent>();
        }

        public Task<V2MoneyManagementTransactionCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2MoneyManagementTransactionCreatedEvent>();
        }
    }
}
