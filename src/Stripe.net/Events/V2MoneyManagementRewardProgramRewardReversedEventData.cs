// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2MoneyManagementRewardProgramRewardReversedEventData : StripeEntity<V2MoneyManagementRewardProgramRewardReversedEventData>
    {
        /// <summary>
        /// The connected account whose reward is reversed.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Issuing card spend details for the reversal.
        /// </summary>
        [JsonProperty("card_spend")]
        [STJS.JsonPropertyName("card_spend")]
        public V2MoneyManagementRewardProgramRewardReversedEventDataCardSpend CardSpend { get; set; }

        /// <summary>
        /// The reward to debit from the connected account.
        /// </summary>
        [JsonProperty("reward")]
        [STJS.JsonPropertyName("reward")]
        public V2MoneyManagementRewardProgramRewardReversedEventDataReward Reward { get; set; }
    }
}
