// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TokenAccountIndividualRelationshipOptions : INestedOptions
    {
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
        /// The person's title (e.g., CEO, Support Engineer).
        /// </summary>
        [JsonProperty("title")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("title")]
#endif
        public string Title { get; set; }
    }
}
