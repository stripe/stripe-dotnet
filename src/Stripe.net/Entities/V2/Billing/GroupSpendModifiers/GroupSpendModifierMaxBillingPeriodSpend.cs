// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GroupSpendModifierMaxBillingPeriodSpend : StripeEntity<GroupSpendModifierMaxBillingPeriodSpend>
    {
        /// <summary>
        /// The billing alert associated with the maximum spend threshold.
        /// </summary>
        [JsonProperty("alert")]
        [STJS.JsonPropertyName("alert")]
        public string Alert { get; set; }

        /// <summary>
        /// The maximum invoice spend, measured in custom pricing units.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public GroupSpendModifierMaxBillingPeriodSpendAmount Amount { get; set; }

        /// <summary>
        /// The timestamp from which this spend modifier is effective.
        /// </summary>
        [JsonProperty("effective_from")]
        [STJS.JsonPropertyName("effective_from")]
        public DateTime EffectiveFrom { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The timestamp until which this spend modifier is effective. If not set, the modifier is
        /// effective indefinitely.
        /// </summary>
        [JsonProperty("effective_until")]
        [STJS.JsonPropertyName("effective_until")]
        public DateTime? EffectiveUntil { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
