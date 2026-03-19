// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AlertSpendThresholdGteCustomPricingUnitOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// The ID of the custom pricing unit.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// A positive decimal string representing the amount of the custom pricing unit threshold.
        /// </summary>
        [JsonProperty("value")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("value")]
        public decimal? Value { get; set; }
    }
}
