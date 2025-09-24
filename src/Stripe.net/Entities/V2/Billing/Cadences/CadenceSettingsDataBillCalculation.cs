// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CadenceSettingsDataBillCalculation : StripeEntity<CadenceSettingsDataBillCalculation>
    {
        /// <summary>
        /// Settings for calculating tax.
        /// </summary>
        [JsonProperty("tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax")]
#endif
        public CadenceSettingsDataBillCalculationTax Tax { get; set; }
    }
}
