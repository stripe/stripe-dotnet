// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AlertCreditBalanceThresholdLteOptions : INestedOptions
    {
        /// <summary>
        /// Specify the type of this balance. We currently only support <c>monetary</c> billing
        /// credits.
        /// One of: <c>custom_pricing_unit</c>, or <c>monetary</c>.
        /// </summary>
        [JsonProperty("balance_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balance_type")]
#endif
        public string BalanceType { get; set; }

        /// <summary>
        /// The custom pricing unit amount.
        /// </summary>
        [JsonProperty("custom_pricing_unit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_pricing_unit")]
#endif
        public AlertCreditBalanceThresholdLteCustomPricingUnitOptions CustomPricingUnit { get; set; }

        /// <summary>
        /// The monetary amount.
        /// </summary>
        [JsonProperty("monetary")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("monetary")]
#endif
        public AlertCreditBalanceThresholdLteMonetaryOptions Monetary { get; set; }
    }
}
