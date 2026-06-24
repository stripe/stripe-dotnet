// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractBillingSettingsBillSettingsDetails : StripeEntity<ContractBillingSettingsBillSettingsDetails>
    {
        /// <summary>
        /// Calculation settings.
        /// </summary>
        [JsonProperty("calculation")]
        [STJS.JsonPropertyName("calculation")]
        public ContractBillingSettingsBillSettingsDetailsCalculation Calculation { get; set; }

        /// <summary>
        /// Invoice settings.
        /// </summary>
        [JsonProperty("invoice")]
        [STJS.JsonPropertyName("invoice")]
        public ContractBillingSettingsBillSettingsDetailsInvoice Invoice { get; set; }
    }
}
