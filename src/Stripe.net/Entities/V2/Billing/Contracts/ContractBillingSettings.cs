// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractBillingSettings : StripeEntity<ContractBillingSettings>
    {
        /// <summary>
        /// Billing settings details for the contract.
        /// </summary>
        [JsonProperty("contract_billing_details")]
        [STJS.JsonPropertyName("contract_billing_details")]
        public ContractBillingSettingsContractBillingDetails ContractBillingDetails { get; set; }
    }
}
