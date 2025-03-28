// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Encodes whether a FinancialAccount has access to a particular feature. Stripe or the
        /// platform can control features via the requested field.
        /// </summary>
        [JsonProperty("features")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("features")]
#endif
        public FinancialAccountFeaturesOptions Features { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
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

        /// <summary>
        /// The currencies the FinancialAccount can hold a balance in.
        /// </summary>
        [JsonProperty("supported_currencies")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("supported_currencies")]
#endif
        public List<string> SupportedCurrencies { get; set; }
    }
}
