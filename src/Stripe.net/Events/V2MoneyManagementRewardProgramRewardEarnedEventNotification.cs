// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a reward program produces a reward for a connected account. Credit
    /// <c>reward.amount</c> to the account. Use the event ID as the idempotency key.
    /// </summary>
    public class V2MoneyManagementRewardProgramRewardEarnedEventNotification : V2.Core.EventNotification
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
        public Task<V2.MoneyManagement.RewardProgram> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.MoneyManagement.RewardProgram>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.MoneyManagement.RewardProgram FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.MoneyManagement.RewardProgram>(this.RelatedObject);
        }

        public V2MoneyManagementRewardProgramRewardEarnedEvent FetchEvent()
        {
            return this.FetchEvent<V2MoneyManagementRewardProgramRewardEarnedEvent>();
        }

        public Task<V2MoneyManagementRewardProgramRewardEarnedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2MoneyManagementRewardProgramRewardEarnedEvent>();
        }
    }
}
