// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdateBillingSettingsOptions : INestedOptions
    {
        /// <summary>
        /// The bill settings to update (tax calculation type and/or invoice time until due).
        /// </summary>
        [JsonProperty("bill_settings_details")]
        [STJS.JsonPropertyName("bill_settings_details")]
        public ContractUpdateBillingSettingsBillSettingsDetailsOptions BillSettingsDetails { get; set; }

        /// <summary>
        /// The billing profile details to update.
        /// </summary>
        [JsonProperty("billing_profile_details")]
        [STJS.JsonPropertyName("billing_profile_details")]
        public ContractUpdateBillingSettingsBillingProfileDetailsOptions BillingProfileDetails { get; set; }

        /// <summary>
        /// The collection settings details to update on the contract.
        /// </summary>
        [JsonProperty("collection_settings_details")]
        [STJS.JsonPropertyName("collection_settings_details")]
        public ContractUpdateBillingSettingsCollectionSettingsDetailsOptions CollectionSettingsDetails { get; set; }
    }
}
