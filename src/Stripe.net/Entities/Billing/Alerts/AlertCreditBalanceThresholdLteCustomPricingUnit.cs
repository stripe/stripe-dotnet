// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AlertCreditBalanceThresholdLteCustomPricingUnit : StripeEntity<AlertCreditBalanceThresholdLteCustomPricingUnit>, IHasId
    {
        /// <summary>
        /// The custom pricing unit object.
        /// </summary>
        [JsonProperty("custom_pricing_unit_details")]
        [STJS.JsonPropertyName("custom_pricing_unit_details")]
        public AlertCreditBalanceThresholdLteCustomPricingUnitCustomPricingUnitDetails CustomPricingUnitDetails { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// A positive decimal string representing the amount.
        /// </summary>
        [JsonProperty("value")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("value")]
        public decimal Value { get; set; }
    }
}
