// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdateBillingSettingsBillSettingsDetailsCalculationOptions : INestedOptions
    {
        /// <summary>
        /// Tax calculation settings.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public ContractUpdateBillingSettingsBillSettingsDetailsCalculationTaxOptions Tax { get; set; }
    }
}
