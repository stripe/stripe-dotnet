// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CadenceSettingsDataBillCalculation : StripeEntity<CadenceSettingsDataBillCalculation>
    {
        /// <summary>
        /// Settings for calculating tax.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public CadenceSettingsDataBillCalculationTax Tax { get; set; }
    }
}
