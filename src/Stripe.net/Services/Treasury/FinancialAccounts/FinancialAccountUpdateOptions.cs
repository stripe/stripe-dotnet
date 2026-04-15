// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAccountUpdateOptions : BaseOptions, IHasMetadata
    {
        private string nickname;

        /// <summary>
        /// Encodes whether a FinancialAccount has access to a particular feature, with a status
        /// enum and associated <c>status_details</c>. Stripe or the platform may control features
        /// via the requested field.
        /// </summary>
        [JsonProperty("features")]
        [STJS.JsonPropertyName("features")]
        public FinancialAccountFeaturesOptions Features { get; set; }

        /// <summary>
        /// A different bank account where funds can be deposited/debited in order to get the
        /// closing FA's balance to $0.
        /// </summary>
        [JsonProperty("forwarding_settings")]
        [STJS.JsonPropertyName("forwarding_settings")]
        public FinancialAccountForwardingSettingsOptions ForwardingSettings { get; set; }

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
    }
}
