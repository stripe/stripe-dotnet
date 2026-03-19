// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentityIndividualRelationship : StripeEntity<AccountIdentityIndividualRelationship>
    {
        /// <summary>
        /// Whether the individual is an authorizer of the Account's identity.
        /// </summary>
        [JsonProperty("authorizer")]
        [STJS.JsonPropertyName("authorizer")]
        public bool? Authorizer { get; set; }

        /// <summary>
        /// Whether the individual is a director of the Account's identity. Directors are typically
        /// members of the governing board of the company or are responsible for making sure that
        /// the company meets its regulatory obligations.
        /// </summary>
        [JsonProperty("director")]
        [STJS.JsonPropertyName("director")]
        public bool? Director { get; set; }

        /// <summary>
        /// Whether the individual has significant responsibility to control, manage, or direct the
        /// organization.
        /// </summary>
        [JsonProperty("executive")]
        [STJS.JsonPropertyName("executive")]
        public bool? Executive { get; set; }

        /// <summary>
        /// Whether the individual is the legal guardian of the Account's representative.
        /// </summary>
        [JsonProperty("legal_guardian")]
        [STJS.JsonPropertyName("legal_guardian")]
        public bool? LegalGuardian { get; set; }

        /// <summary>
        /// Whether the individual is an owner of the Account's identity.
        /// </summary>
        [JsonProperty("owner")]
        [STJS.JsonPropertyName("owner")]
        public bool? Owner { get; set; }

        /// <summary>
        /// The percentage of the Account's identity that the individual owns.
        /// </summary>
        [JsonProperty("percent_ownership")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("percent_ownership")]
        public decimal? PercentOwnership { get; set; }

        /// <summary>
        /// Whether the individual is authorized as the primary representative of the Account. This
        /// is the person nominated by the business to provide information about themselves, and
        /// general information about the account. There can only be one representative at any given
        /// time. At the time the account is created, this person should be set to the person
        /// responsible for opening the account.
        /// </summary>
        [JsonProperty("representative")]
        [STJS.JsonPropertyName("representative")]
        public bool? Representative { get; set; }

        /// <summary>
        /// The individual's title (e.g., CEO, Support Engineer).
        /// </summary>
        [JsonProperty("title")]
        [STJS.JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
