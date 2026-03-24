// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CadenceSettingsDataBillCalculationTax : StripeEntity<CadenceSettingsDataBillCalculationTax>
    {
        /// <summary>
        /// Determines if tax will be calculated automatically based on a PTC or manually based on
        /// rules defined by the merchant. Defaults to "manual".
        /// One of: <c>automatic</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
