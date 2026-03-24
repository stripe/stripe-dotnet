// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TokenAccountIndividualRelationshipOptions : INestedOptions, IHasSetTracking
    {
        private decimal? percentOwnership;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

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
