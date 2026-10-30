// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2MoneyManagementRewardProgramRewardEarnedEventDataCardSpend : StripeEntity<V2MoneyManagementRewardProgramRewardEarnedEventDataCardSpend>
    {
        /// <summary>
        /// The Issuing cardholder whose spend earned the reward.
        /// </summary>
        [JsonProperty("cardholder")]
        [STJS.JsonPropertyName("cardholder")]
        public string Cardholder { get; set; }

        /// <summary>
        /// The Issuing transaction that earned the reward. Present when the reward is calculated
        /// from a single Issuing transaction.
        /// </summary>
        [JsonProperty("issuing_transaction")]
        [STJS.JsonPropertyName("issuing_transaction")]
        public string IssuingTransaction { get; set; }
    }
}
