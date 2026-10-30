// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2MoneyManagementRewardProgramRewardReversedEventDataReward : StripeEntity<V2MoneyManagementRewardProgramRewardReversedEventDataReward>
    {
        /// <summary>
        /// The reward amount. Always positive; the event type determines whether to credit or debit
        /// the connected account.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// The period over which the reward was earned. Present when the reward is calculated over
        /// an earning period rather than from a single Issuing transaction.
        /// </summary>
        [JsonProperty("earning_period")]
        [STJS.JsonPropertyName("earning_period")]
        public V2MoneyManagementRewardProgramRewardReversedEventDataRewardEarningPeriod EarningPeriod { get; set; }
    }
}
