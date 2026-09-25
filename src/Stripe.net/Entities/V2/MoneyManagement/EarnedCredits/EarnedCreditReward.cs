// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EarnedCreditReward : StripeEntity<EarnedCreditReward>
    {
        /// <summary>
        /// The program from which the reward was earned.
        /// One of: <c>platform_cash_rewards</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("earned_from")]
        [STJS.JsonPropertyName("earned_from")]
        public string EarnedFrom { get; set; }

        /// <summary>
        /// The Account that funded the reward.
        /// </summary>
        [JsonProperty("from_account")]
        [STJS.JsonPropertyName("from_account")]
        public string FromAccount { get; set; }

        /// <summary>
        /// The OutboundPayment that delivered the reward.
        /// </summary>
        [JsonProperty("outbound_payment")]
        [STJS.JsonPropertyName("outbound_payment")]
        public string OutboundPayment { get; set; }
    }
}
