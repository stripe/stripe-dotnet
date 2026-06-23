// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreateBillingSettingsOptions : INestedOptions
    {
        /// <summary>
        /// The bill settings details configures invoice and tax settings for the contract.
        /// </summary>
        [JsonProperty("bill_settings_details")]
        [STJS.JsonPropertyName("bill_settings_details")]
        public ContractCreateBillingSettingsBillSettingsDetailsOptions BillSettingsDetails { get; set; }

        /// <summary>
        /// The billing profile details configures who is charged for the contract.
        /// </summary>
        [JsonProperty("billing_profile_details")]
        [STJS.JsonPropertyName("billing_profile_details")]
        public ContractCreateBillingSettingsBillingProfileDetailsOptions BillingProfileDetails { get; set; }

        /// <summary>
        /// The collection settings details configures how payments are collected on the contract.
        /// </summary>
        [JsonProperty("collection_settings_details")]
        [STJS.JsonPropertyName("collection_settings_details")]
        public ContractCreateBillingSettingsCollectionSettingsDetailsOptions CollectionSettingsDetails { get; set; }
    }
}
