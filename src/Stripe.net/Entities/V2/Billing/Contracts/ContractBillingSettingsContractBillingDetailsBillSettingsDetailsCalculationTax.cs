// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractBillingSettingsContractBillingDetailsBillSettingsDetailsCalculationTax : StripeEntity<ContractBillingSettingsContractBillingDetailsBillSettingsDetailsCalculationTax>
    {
        /// <summary>
        /// The type of tax calculation.
        /// One of: <c>automatic</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
