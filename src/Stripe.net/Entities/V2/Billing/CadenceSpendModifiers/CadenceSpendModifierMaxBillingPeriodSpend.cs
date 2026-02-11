// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CadenceSpendModifierMaxBillingPeriodSpend : StripeEntity<CadenceSpendModifierMaxBillingPeriodSpend>
    {
        /// <summary>
        /// The billing alert associated with the maximum spend threshold.
        /// </summary>
        [JsonProperty("alert")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alert")]
#endif
        public string Alert { get; set; }

        /// <summary>
        /// The maximum amount of invoice spend.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public CadenceSpendModifierMaxBillingPeriodSpendAmount Amount { get; set; }

        /// <summary>
        /// The configuration for the overage rate for the custom pricing unit.
        /// </summary>
        [JsonProperty("custom_pricing_unit_overage_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_pricing_unit_overage_rate")]
#endif
        public CadenceSpendModifierMaxBillingPeriodSpendCustomPricingUnitOverageRate CustomPricingUnitOverageRate { get; set; }

        /// <summary>
        /// The timestamp from which this spend modifier is effective.
        /// </summary>
        [JsonProperty("effective_from")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("effective_from")]
#endif
        public DateTime EffectiveFrom { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The timestamp until which this spend modifier is effective. If not set, the modifier is
        /// effective indefinitely.
        /// </summary>
        [JsonProperty("effective_until")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("effective_until")]
#endif
        public DateTime? EffectiveUntil { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
