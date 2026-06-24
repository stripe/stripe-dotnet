// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreateBillingSettingsBillSettingsDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Calculation settings.
        /// </summary>
        [JsonProperty("calculation")]
        [STJS.JsonPropertyName("calculation")]
        public ContractCreateBillingSettingsBillSettingsDetailsCalculationOptions Calculation { get; set; }

        /// <summary>
        /// Invoice settings.
        /// </summary>
        [JsonProperty("invoice")]
        [STJS.JsonPropertyName("invoice")]
        public ContractCreateBillingSettingsBillSettingsDetailsInvoiceOptions Invoice { get; set; }
    }
}
