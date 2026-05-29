// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreateBillingSettingsContractBillingDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The bill settings details.
        /// </summary>
        [JsonProperty("bill_settings_details")]
        [STJS.JsonPropertyName("bill_settings_details")]
        public ContractCreateBillingSettingsContractBillingDetailsBillSettingsDetailsOptions BillSettingsDetails { get; set; }

        /// <summary>
        /// The billing profile details.
        /// </summary>
        [JsonProperty("billing_profile_details")]
        [STJS.JsonPropertyName("billing_profile_details")]
        public ContractCreateBillingSettingsContractBillingDetailsBillingProfileDetailsOptions BillingProfileDetails { get; set; }

        /// <summary>
        /// The collection settings details.
        /// </summary>
        [JsonProperty("collection_settings_details")]
        [STJS.JsonPropertyName("collection_settings_details")]
        public ContractCreateBillingSettingsContractBillingDetailsCollectionSettingsDetailsOptions CollectionSettingsDetails { get; set; }
    }
}
