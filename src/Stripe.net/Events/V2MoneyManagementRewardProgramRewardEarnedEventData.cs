// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2MoneyManagementRewardProgramRewardEarnedEventData : StripeEntity<V2MoneyManagementRewardProgramRewardEarnedEventData>
    {
        /// <summary>
        /// The connected account that earned the reward.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Issuing card spend details for the reward.
        /// </summary>
        [JsonProperty("card_spend")]
        [STJS.JsonPropertyName("card_spend")]
        public V2MoneyManagementRewardProgramRewardEarnedEventDataCardSpend CardSpend { get; set; }

        /// <summary>
        /// The reward to credit to the connected account.
        /// </summary>
        [JsonProperty("reward")]
        [STJS.JsonPropertyName("reward")]
        public V2MoneyManagementRewardProgramRewardEarnedEventDataReward Reward { get; set; }
    }
}
