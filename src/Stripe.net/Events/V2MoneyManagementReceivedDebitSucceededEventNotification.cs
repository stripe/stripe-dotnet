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
    /// Occurs when a ReceivedDebit succeeds.
    /// </summary>
    public class V2MoneyManagementReceivedDebitSucceededEventNotification : V2.EventNotification
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
        public Task<V2.MoneyManagement.ReceivedDebit> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.MoneyManagement.ReceivedDebit>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.MoneyManagement.ReceivedDebit FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.MoneyManagement.ReceivedDebit>(this.RelatedObject);
        }

        public V2MoneyManagementReceivedDebitSucceededEvent FetchEvent()
        {
            return this.FetchEvent<V2MoneyManagementReceivedDebitSucceededEvent>();
        }

        public Task<V2MoneyManagementReceivedDebitSucceededEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2MoneyManagementReceivedDebitSucceededEvent>();
        }
    }
}
