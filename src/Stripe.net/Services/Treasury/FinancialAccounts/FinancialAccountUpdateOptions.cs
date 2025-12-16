// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Encodes whether a FinancialAccount has access to a particular feature, with a status
        /// enum and associated <c>status_details</c>. Stripe or the platform may control features
        /// via the requested field.
        /// </summary>
        [JsonProperty("features")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("features")]
#endif
        public FinancialAccountFeaturesOptions Features { get; set; }

        /// <summary>
        /// A different bank account where funds can be deposited/debited in order to get the
        /// closing FA's balance to $0.
        /// </summary>
        [JsonProperty("forwarding_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("forwarding_settings")]
#endif
        public FinancialAccountForwardingSettingsOptions ForwardingSettings { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The nickname for the FinancialAccount.
        /// </summary>
        [JsonProperty("nickname")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("nickname")]
#endif
        public string Nickname { get; set; }

        /// <summary>
        /// The set of functionalities that the platform can restrict on the FinancialAccount.
        /// </summary>
        [JsonProperty("platform_restrictions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("platform_restrictions")]
#endif
        public FinancialAccountPlatformRestrictionsOptions PlatformRestrictions { get; set; }
    }
}
