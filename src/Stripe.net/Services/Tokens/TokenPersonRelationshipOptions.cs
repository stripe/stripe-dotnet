// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TokenPersonRelationshipOptions : INestedOptions
    {
        /// <summary>
        /// Whether the person is the authorizer of the account's representative.
        /// </summary>
        [JsonProperty("authorizer")]
        public bool? Authorizer { get; set; }

        /// <summary>
        /// Whether the person is a director of the account's legal entity. Directors are typically
        /// members of the governing board of the company, or responsible for ensuring the company
        /// meets its regulatory obligations.
        /// </summary>
        [JsonProperty("director")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("director")]
#endif
        public bool? Director { get; set; }

        /// <summary>
        /// Whether the person has significant responsibility to control, manage, or direct the
        /// organization.
        /// </summary>
        [JsonProperty("executive")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("executive")]
#endif
        public bool? Executive { get; set; }

        /// <summary>
        /// Whether the person is the legal guardian of the account's representative.
        /// </summary>
        [JsonProperty("legal_guardian")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("legal_guardian")]
#endif
        public bool? LegalGuardian { get; set; }

        /// <summary>
        /// Whether the person is an owner of the account’s legal entity.
        /// </summary>
        [JsonProperty("owner")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("owner")]
#endif
        public bool? Owner { get; set; }

        /// <summary>
        /// The percent owned by the person of the account's legal entity.
        /// </summary>
        [JsonProperty("percent_ownership")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("percent_ownership")]
#endif
        public decimal? PercentOwnership { get; set; }

        /// <summary>
        /// Whether the person is authorized as the primary representative of the account. This is
        /// the person nominated by the business to provide information about themselves, and
        /// general information about the account. There can only be one representative at any given
        /// time. At the time the account is created, this person should be set to the person
        /// responsible for opening the account.
        /// </summary>
        [JsonProperty("representative")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("representative")]
#endif
        public bool? Representative { get; set; }

        /// <summary>
        /// The person's title (e.g., CEO, Support Engineer).
        /// </summary>
        [JsonProperty("title")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("title")]
#endif
        public string Title { get; set; }
    }
}
