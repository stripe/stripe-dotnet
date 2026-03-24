// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TokenPersonRelationshipOptions : INestedOptions, IHasSetTracking
    {
        private decimal? percentOwnership;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Whether the person is the authorizer of the account's representative.
        /// </summary>
        [JsonProperty("authorizer")]
        [STJS.JsonPropertyName("authorizer")]
        public bool? Authorizer { get; set; }

        /// <summary>
        /// Whether the person is a director of the account's legal entity. Directors are typically
        /// members of the governing board of the company, or responsible for ensuring the company
        /// meets its regulatory obligations.
        /// </summary>
        [JsonProperty("director")]
        [STJS.JsonPropertyName("director")]
        public bool? Director { get; set; }

        /// <summary>
        /// Whether the person has significant responsibility to control, manage, or direct the
        /// organization.
        /// </summary>
        [JsonProperty("executive")]
        [STJS.JsonPropertyName("executive")]
        public bool? Executive { get; set; }

        /// <summary>
        /// Whether the person is the legal guardian of the account's representative.
        /// </summary>
        [JsonProperty("legal_guardian")]
        [STJS.JsonPropertyName("legal_guardian")]
        public bool? LegalGuardian { get; set; }

        /// <summary>
        /// Whether the person is an owner of the account’s legal entity.
        /// </summary>
        [JsonProperty("owner")]
        [STJS.JsonPropertyName("owner")]
        public bool? Owner { get; set; }

        /// <summary>
        /// The percent owned by the person of the account's legal entity.
        /// </summary>
        [JsonProperty("percent_ownership")]
        [STJS.JsonPropertyName("percent_ownership")]
        public decimal? PercentOwnership
        {
            get => this.percentOwnership;
            set
            {
                this.percentOwnership = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Whether the person is authorized as the primary representative of the account. This is
        /// the person nominated by the business to provide information about themselves, and
        /// general information about the account. There can only be one representative at any given
        /// time. At the time the account is created, this person should be set to the person
        /// responsible for opening the account.
        /// </summary>
        [JsonProperty("representative")]
        [STJS.JsonPropertyName("representative")]
        public bool? Representative { get; set; }

        /// <summary>
        /// The person's title (e.g., CEO, Support Engineer).
        /// </summary>
        [JsonProperty("title")]
        [STJS.JsonPropertyName("title")]
        public string Title { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
