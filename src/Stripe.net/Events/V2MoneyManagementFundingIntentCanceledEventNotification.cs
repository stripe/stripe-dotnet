// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a FundingIntent transitions into the canceled state.
    /// </summary>
    public class V2MoneyManagementFundingIntentCanceledEventNotification : V2.Core.EventNotification
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
        public Task<V2.MoneyManagement.FundingIntent> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.MoneyManagement.FundingIntent>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.MoneyManagement.FundingIntent FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.MoneyManagement.FundingIntent>(this.RelatedObject);
        }

        public V2MoneyManagementFundingIntentCanceledEvent FetchEvent()
        {
            return this.FetchEvent<V2MoneyManagementFundingIntentCanceledEvent>();
        }

        public Task<V2MoneyManagementFundingIntentCanceledEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2MoneyManagementFundingIntentCanceledEvent>();
        }
    }
}
