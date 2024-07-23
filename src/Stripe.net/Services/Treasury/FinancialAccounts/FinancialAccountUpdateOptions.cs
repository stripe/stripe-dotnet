// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class FinancialAccountUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The display name for the FinancialAccount. Use this field to customize the names of the
        /// FinancialAccounts for your connected accounts. Unlike the <c>nickname</c> field,
        /// <c>display_name</c> is not internal metadata and will be exposed to connected accounts.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Encodes whether a FinancialAccount has access to a particular feature, with a status
        /// enum and associated <c>status_details</c>. Stripe or the platform may control features
        /// via the requested field.
        /// </summary>
        [JsonProperty("features")]
        public FinancialAccountFeaturesOptions Features { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The set of functionalities that the platform can restrict on the FinancialAccount.
        /// </summary>
        [JsonProperty("platform_restrictions")]
        public FinancialAccountPlatformRestrictionsOptions PlatformRestrictions { get; set; }
    }
}
