// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreateBillingSettingsContractBillingDetailsBillingProfileDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The customer who pays for the contract invoice.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The default payment method for the contract.
        /// </summary>
        [JsonProperty("default_payment_method")]
        [STJS.JsonPropertyName("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }
    }
}
