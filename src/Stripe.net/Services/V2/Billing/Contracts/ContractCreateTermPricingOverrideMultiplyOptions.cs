// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreateTermPricingOverrideMultiplyOptions : INestedOptions
    {
        /// <summary>
        /// The multiplier, for example 0.85 for a 15% discount.
        /// </summary>
        [JsonProperty("factor")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("factor")]
        public decimal? Factor { get; set; }
    }
}
