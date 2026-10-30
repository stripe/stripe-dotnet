// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a FundingIntent transitions into the requires_action state.
    /// </summary>
    public class V2MoneyManagementFundingIntentRequiresActionEventNotification : V2.Core.EventNotification
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

        public V2MoneyManagementFundingIntentRequiresActionEvent FetchEvent()
        {
            return this.FetchEvent<V2MoneyManagementFundingIntentRequiresActionEvent>();
        }

        public Task<V2MoneyManagementFundingIntentRequiresActionEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2MoneyManagementFundingIntentRequiresActionEvent>();
        }
    }
}
