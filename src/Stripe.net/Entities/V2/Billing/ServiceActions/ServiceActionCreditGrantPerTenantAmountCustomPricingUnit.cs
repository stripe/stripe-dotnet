// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ServiceActionCreditGrantPerTenantAmountCustomPricingUnit : StripeEntity<ServiceActionCreditGrantPerTenantAmountCustomPricingUnit>, IHasId
    {
        /// <summary>
        /// The Custom Pricing Unit object.
        /// </summary>
        [JsonProperty("custom_pricing_unit_details")]
        [STJS.JsonPropertyName("custom_pricing_unit_details")]
        public CustomPricingUnit CustomPricingUnitDetails { get; set; }

        /// <summary>
        /// The id of the custom pricing unit.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The value of the credit grant, decimal value represented as a string.
        /// </summary>
        [JsonProperty("value")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("value")]
        public decimal Value { get; set; }
    }
}
