// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class BillSettingCreateCalculationOptions : INestedOptions
    {
        /// <summary>
        /// Settings for calculating tax.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public BillSettingCreateCalculationTaxOptions Tax { get; set; }
    }
}
