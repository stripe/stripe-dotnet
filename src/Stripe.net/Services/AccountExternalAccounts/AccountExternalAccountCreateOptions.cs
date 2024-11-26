// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountExternalAccountCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// When set to true, or if this is the first external account added in this currency, this
        /// account becomes the default external account for its currency.
        /// </summary>
        [JsonProperty("default_for_currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_for_currency")]
#endif
        public bool? DefaultForCurrency { get; set; }

        /// <summary>
        /// Please refer to full <a href="https://stripe.com/docs/api">documentation</a> instead.
        /// </summary>
        [JsonProperty("external_account")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("external_account")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<string, AccountExternalAccountCardOptions, AccountExternalAccountBankAccountOptions, AccountExternalAccountCardTokenOptions> ExternalAccount { get; set; }

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
    }
}
