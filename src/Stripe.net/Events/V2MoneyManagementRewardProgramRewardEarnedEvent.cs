// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a reward program produces a reward for a connected account. Credit
    /// <c>reward.amount</c> to the account. Use the event ID as the idempotency key.
    /// </summary>
    public class V2MoneyManagementRewardProgramRewardEarnedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.money_management.reward_program.reward_earned event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public V2MoneyManagementRewardProgramRewardEarnedEventData Data { get; set; }

        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
        [STJS.JsonPropertyName("related_object")]
        public V2.Core.EventRelatedObject RelatedObject { get; set; }

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
    }
}
