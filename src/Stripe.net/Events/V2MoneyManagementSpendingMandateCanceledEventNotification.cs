// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a SpendingMandate is successfully canceled.
    /// </summary>
    public class V2MoneyManagementSpendingMandateCanceledEventNotification : V2.Core.EventNotification
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
        public Task<V2.MoneyManagement.SpendingMandate> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.MoneyManagement.SpendingMandate>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.MoneyManagement.SpendingMandate FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.MoneyManagement.SpendingMandate>(this.RelatedObject);
        }

        public V2MoneyManagementSpendingMandateCanceledEvent FetchEvent()
        {
            return this.FetchEvent<V2MoneyManagementSpendingMandateCanceledEvent>();
        }

        public Task<V2MoneyManagementSpendingMandateCanceledEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2MoneyManagementSpendingMandateCanceledEvent>();
        }
    }
}
