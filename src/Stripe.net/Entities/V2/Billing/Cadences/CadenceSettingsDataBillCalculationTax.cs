// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CadenceSettingsDataBillCalculationTax : StripeEntity<CadenceSettingsDataBillCalculationTax>
    {
        /// <summary>
        /// Determines if tax will be calculated automatically based on a PTC or manually based on
        /// rules defined by the merchant. Defaults to "manual".
        /// One of: <c>automatic</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
