// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when a ReceivedCredit is attempted to your balance and fails. See the
    /// status_details for more information.
    /// </summary>
    public class PushedV2MoneyManagementReceivedCreditFailedEvent : V2.PushedEvent
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

        public V2MoneyManagementReceivedCreditFailedEvent Pull()
        {
            return this.PullEvent<V2MoneyManagementReceivedCreditFailedEvent>();
        }

        public Task<V2MoneyManagementReceivedCreditFailedEvent> PullAsync()
        {
            return this.PullEventAsync<V2MoneyManagementReceivedCreditFailedEvent>();
        }
    }
}
