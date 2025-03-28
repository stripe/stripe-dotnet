// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// An Account Configuration which allows the Account to take on a key persona across Stripe
        /// products.
        /// </summary>
        [JsonProperty("configuration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("configuration")]
#endif
        public AccountUpdateConfigurationOptions Configuration { get; set; }

        /// <summary>
        /// The default contact email address for the Account. Required when configuring the account
        /// as a merchant or recipient.
        /// </summary>
        [JsonProperty("contact_email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("contact_email")]
#endif
        public string ContactEmail { get; set; }

        /// <summary>
        /// A value indicating the Stripe dashboard this Account has access to. This will depend on
        /// which configurations are enabled for this account.
        /// One of: <c>express</c>, <c>full</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("dashboard")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dashboard")]
#endif
        public string Dashboard { get; set; }

        /// <summary>
        /// Default values to be used on Account Configurations.
        /// </summary>
        [JsonProperty("defaults")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("defaults")]
#endif
        public AccountUpdateDefaultsOptions Defaults { get; set; }

        /// <summary>
        /// A descriptive name for the Account. This name will be surfaced in the Stripe Dashboard
        /// and on any invoices sent to the Account.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// Information about the company, individual, and business represented by the Account.
        /// </summary>
        [JsonProperty("identity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("identity")]
#endif
        public AccountUpdateIdentityOptions Identity { get; set; }

        /// <summary>
        /// Additional fields to include in the response.
        /// One of: <c>configuration.customer</c>, <c>configuration.merchant</c>,
        /// <c>configuration.recipient</c>, <c>defaults</c>, <c>identity</c>, or
        /// <c>requirements</c>.
        /// </summary>
        [JsonProperty("include")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("include")]
#endif
        public List<string> Include { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }
    }
}
