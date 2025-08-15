// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Configurations applied to this Account in order to allow it to be used in different
        /// product flows. Currently only supports the recipient configuration.
        /// </summary>
        [JsonProperty("configuration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("configuration")]
#endif
        public AccountUpdateConfigurationOptions Configuration { get; set; }

        /// <summary>
        /// The default contact email address for the Account. This field is optional, but must be
        /// supplied before the recipient configuration can be populated.
        /// </summary>
        [JsonProperty("email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email")]
#endif
        public string Email { get; set; }

        /// <summary>
        /// Closed Enum. Additional fields to include in the response. Currently supports
        /// <c>configuration.recipient_data</c>, <c>legal_entity_data</c>, <c>requirements</c>, and
        /// <c>supportable_features.recipient_data</c>.
        /// One of: <c>configuration.recipient_data</c>, <c>legal_entity_data</c>,
        /// <c>requirements</c>, or <c>supportable_features.recipient_data</c>.
        /// </summary>
        [JsonProperty("include")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("include")]
#endif
        public List<string> Include { get; set; }

        /// <summary>
        /// Information about the company or individual that this Account represents. Stripe may
        /// require Legal Entity information in order to enable Features requested on the Account.
        /// </summary>
        [JsonProperty("legal_entity_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("legal_entity_data")]
#endif
        public AccountUpdateLegalEntityDataOptions LegalEntityData { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A descriptive name for the Account. This name will be surfaced in the Account directory
        /// in the dashboard.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }
    }
}
