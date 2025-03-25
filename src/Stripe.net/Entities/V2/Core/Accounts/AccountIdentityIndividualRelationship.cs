// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountIdentityIndividualRelationship : StripeEntity<AccountIdentityIndividualRelationship>
    {
        /// <summary>
        /// Whether the individual is a director of the Account’s legal entity. Directors are
        /// typically members of the governing board of the company, or responsible for ensuring the
        /// company meets its regulatory obligations.
        /// </summary>
        [JsonProperty("director")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("director")]
#endif
        public bool? Director { get; set; }

        /// <summary>
        /// Whether the individual has significant responsibility to control, manage, or direct the
        /// organization.
        /// </summary>
        [JsonProperty("executive")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("executive")]
#endif
        public bool? Executive { get; set; }

        /// <summary>
        /// Whether the individual is the legal guardian of the Account’s representative.
        /// </summary>
        [JsonProperty("legal_guardian")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("legal_guardian")]
#endif
        public bool? LegalGuardian { get; set; }

        /// <summary>
        /// Whether the individual is an owner of the Account’s legal entity.
        /// </summary>
        [JsonProperty("owner")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("owner")]
#endif
        public bool? Owner { get; set; }

        /// <summary>
        /// The percent owned by the individual of the Account’s legal entity.
        /// </summary>
        [JsonProperty("percent_ownership")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("percent_ownership")]
#endif
        public string PercentOwnership { get; set; }

        /// <summary>
        /// Whether the individual is authorized as the primary representative of the Account. This
        /// is the person nominated by the business to provide information about themselves, and
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
        /// The individual's title (e.g., CEO, Support Engineer).
        /// </summary>
        [JsonProperty("title")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("title")]
#endif
        public string Title { get; set; }
    }
}
