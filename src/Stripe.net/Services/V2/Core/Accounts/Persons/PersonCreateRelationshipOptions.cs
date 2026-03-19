// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PersonCreateRelationshipOptions : INestedOptions
    {
        /// <summary>
        /// Whether the individual is an authorizer of the Account's identity.
        /// </summary>
        [JsonProperty("authorizer")]
        [STJS.JsonPropertyName("authorizer")]
        public bool? Authorizer { get; set; }

        /// <summary>
        /// Indicates whether the person is a director of the associated legal entity.
        /// </summary>
        [JsonProperty("director")]
        [STJS.JsonPropertyName("director")]
        public bool? Director { get; set; }

        /// <summary>
        /// Indicates whether the person is an executive of the associated legal entity.
        /// </summary>
        [JsonProperty("executive")]
        [STJS.JsonPropertyName("executive")]
        public bool? Executive { get; set; }

        /// <summary>
        /// Indicates whether the person is a legal guardian of the associated legal entity.
        /// </summary>
        [JsonProperty("legal_guardian")]
        [STJS.JsonPropertyName("legal_guardian")]
        public bool? LegalGuardian { get; set; }

        /// <summary>
        /// Indicates whether the person is an owner of the associated legal entity.
        /// </summary>
        [JsonProperty("owner")]
        [STJS.JsonPropertyName("owner")]
        public bool? Owner { get; set; }

        /// <summary>
        /// The percentage of ownership the person has in the associated legal entity.
        /// </summary>
        [JsonProperty("percent_ownership")]
        [STJS.JsonPropertyName("percent_ownership")]
        public string PercentOwnership { get; set; }

        /// <summary>
        /// Indicates whether the person is a representative of the associated legal entity.
        /// </summary>
        [JsonProperty("representative")]
        [STJS.JsonPropertyName("representative")]
        public bool? Representative { get; set; }

        /// <summary>
        /// The title or position the person holds in the associated legal entity.
        /// </summary>
        [JsonProperty("title")]
        [STJS.JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
