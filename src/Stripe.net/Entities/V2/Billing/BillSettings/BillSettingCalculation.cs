// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BillSettingCalculation : StripeEntity<BillSettingCalculation>
    {
        /// <summary>
        /// Settings for calculating tax.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public BillSettingCalculationTax Tax { get; set; }
    }
}
