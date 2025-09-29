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
    /// Occurs when a ReceivedCredit is attempted to your balance and fails. See the
    /// status_details for more information.
    /// </summary>
    public class V2MoneyManagementReceivedCreditFailedEventNotification : V2.Core.EventNotification
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.Core.EventNotificationRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<V2.MoneyManagement.ReceivedCredit> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.MoneyManagement.ReceivedCredit>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.MoneyManagement.ReceivedCredit FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.MoneyManagement.ReceivedCredit>(this.RelatedObject);
        }

        public V2MoneyManagementReceivedCreditFailedEvent FetchEvent()
        {
            return this.FetchEvent<V2MoneyManagementReceivedCreditFailedEvent>();
        }

        public Task<V2MoneyManagementReceivedCreditFailedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2MoneyManagementReceivedCreditFailedEvent>();
        }
    }
}
