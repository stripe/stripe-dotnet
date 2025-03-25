// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PersonCreateRelationshipOptions : INestedOptions
    {
        /// <summary>
        /// Indicates whether the person is a director of the associated legal entity.
        /// </summary>
        [JsonProperty("director")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("director")]
#endif
        public bool? Director { get; set; }

        /// <summary>
        /// Indicates whether the person is an executive of the associated legal entity.
        /// </summary>
        [JsonProperty("executive")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("executive")]
#endif
        public bool? Executive { get; set; }

        /// <summary>
        /// Indicates whether the person is a legal guardian of the associated legal entity.
        /// </summary>
        [JsonProperty("legal_guardian")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("legal_guardian")]
#endif
        public bool? LegalGuardian { get; set; }

        /// <summary>
        /// Indicates whether the person is an owner of the associated legal entity.
        /// </summary>
        [JsonProperty("owner")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("owner")]
#endif
        public bool? Owner { get; set; }

        /// <summary>
        /// The percentage of ownership the person has in the associated legal entity.
        /// </summary>
        [JsonProperty("percent_ownership")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("percent_ownership")]
#endif
        public string PercentOwnership { get; set; }

        /// <summary>
        /// Indicates whether the person is a representative of the associated legal entity.
        /// </summary>
        [JsonProperty("representative")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("representative")]
#endif
        public bool? Representative { get; set; }

        /// <summary>
        /// The title or position the person holds in the associated legal entity.
        /// </summary>
        [JsonProperty("title")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("title")]
#endif
        public string Title { get; set; }
    }
}
