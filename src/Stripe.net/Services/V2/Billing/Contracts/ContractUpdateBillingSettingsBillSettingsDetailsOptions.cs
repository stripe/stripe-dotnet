// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdateBillingSettingsBillSettingsDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The tax calculation settings to update.
        /// </summary>
        [JsonProperty("calculation")]
        [STJS.JsonPropertyName("calculation")]
        public ContractUpdateBillingSettingsBillSettingsDetailsCalculationOptions Calculation { get; set; }

        /// <summary>
        /// The invoice settings to update.
        /// </summary>
        [JsonProperty("invoice")]
        [STJS.JsonPropertyName("invoice")]
        public ContractUpdateBillingSettingsBillSettingsDetailsInvoiceOptions Invoice { get; set; }
    }
}
