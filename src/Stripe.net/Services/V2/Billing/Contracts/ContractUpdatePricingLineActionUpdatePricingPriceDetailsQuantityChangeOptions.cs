// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdatePricingLineActionUpdatePricingPriceDetailsQuantityChangeOptions : INestedOptions
    {
        /// <summary>
        /// When this quantity change takes effect.
        /// </summary>
        [JsonProperty("effective_at")]
        [STJS.JsonPropertyName("effective_at")]
        public ContractUpdatePricingLineActionUpdatePricingPriceDetailsQuantityChangeEffectiveAtOptions EffectiveAt { get; set; }

        /// <summary>
        /// The quantity to set.
        /// </summary>
        [JsonProperty("set")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("set")]
        public decimal? Set { get; set; }
    }
}
