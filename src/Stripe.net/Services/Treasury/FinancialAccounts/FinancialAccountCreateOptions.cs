// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAccountCreateOptions : BaseOptions, IHasMetadata
    {
        private string displayName;
        private string nickname;

        /// <summary>
        /// The display name for the FinancialAccount. Use this field to customize the names of the
        /// FinancialAccounts for your connected accounts. Unlike the <c>nickname</c> field,
        /// <c>display_name</c> is not internal metadata and will be exposed to connected accounts.
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("display_name")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string DisplayName
        {
            get => this.displayName;
            set
            {
                this.displayName = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Encodes whether a FinancialAccount has access to a particular feature. Stripe or the
        /// platform can control features via the requested field.
        /// </summary>
        [JsonProperty("features")]
        [STJS.JsonPropertyName("features")]
        public FinancialAccountFeaturesOptions Features { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The nickname for the FinancialAccount.
        /// </summary>
        [JsonProperty("nickname", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("nickname")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Nickname
        {
            get => this.nickname;
            set
            {
                this.nickname = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The set of functionalities that the platform can restrict on the FinancialAccount.
        /// </summary>
        [JsonProperty("platform_restrictions")]
        [STJS.JsonPropertyName("platform_restrictions")]
        public FinancialAccountPlatformRestrictionsOptions PlatformRestrictions { get; set; }

        /// <summary>
        /// The currencies the FinancialAccount can hold a balance in.
        /// </summary>
        [JsonProperty("supported_currencies")]
        [STJS.JsonPropertyName("supported_currencies")]
        public List<string> SupportedCurrencies { get; set; }
    }
}
