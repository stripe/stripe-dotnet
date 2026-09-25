// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdatePricingLineActionAddPricingPriceDetailsPricingOverrideOverwritePriceOptions : INestedOptions
    {
        /// <summary>
        /// The per-unit amount to be charged in minor currency units.
        /// </summary>
        [JsonProperty("unit_amount")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("unit_amount")]
        public decimal? UnitAmount { get; set; }
    }
}
