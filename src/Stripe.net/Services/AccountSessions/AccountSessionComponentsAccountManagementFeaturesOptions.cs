// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionComponentsAccountManagementFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// Whether to allow platforms to control bank account collection for their connected
        /// accounts. This feature can only be false for custom accounts (or accounts where the
        /// platform is compliance owner). Otherwise, bank account collection is determined by
        /// compliance requirements.
        /// </summary>
        [JsonProperty("external_account_collection")]
        public bool? ExternalAccountCollection { get; set; }
    }
}
