// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AlertCreditBalanceThresholdLteOptions : INestedOptions
    {
        /// <summary>
        /// Specify the type of this balance. We currently only support <c>monetary</c> billing
        /// credits.
        /// One of: <c>custom_pricing_unit</c>, or <c>monetary</c>.
        /// </summary>
        [JsonProperty("balance_type")]
        [STJS.JsonPropertyName("balance_type")]
        public string BalanceType { get; set; }

        /// <summary>
        /// The custom pricing unit amount.
        /// </summary>
        [JsonProperty("custom_pricing_unit")]
        [STJS.JsonPropertyName("custom_pricing_unit")]
        public AlertCreditBalanceThresholdLteCustomPricingUnitOptions CustomPricingUnit { get; set; }

        /// <summary>
        /// The monetary amount.
        /// </summary>
        [JsonProperty("monetary")]
        [STJS.JsonPropertyName("monetary")]
        public AlertCreditBalanceThresholdLteMonetaryOptions Monetary { get; set; }
    }
}
