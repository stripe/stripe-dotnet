// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2MoneyManagementRewardProgramRewardReversedEventDataRewardEarningPeriod : StripeEntity<V2MoneyManagementRewardProgramRewardReversedEventDataRewardEarningPeriod>
    {
        /// <summary>
        /// End of the earning period, exclusive.
        /// </summary>
        [JsonProperty("end")]
        [STJS.JsonPropertyName("end")]
        public DateTime End { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Start of the earning period, inclusive.
        /// </summary>
        [JsonProperty("start")]
        [STJS.JsonPropertyName("start")]
        public DateTime Start { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
