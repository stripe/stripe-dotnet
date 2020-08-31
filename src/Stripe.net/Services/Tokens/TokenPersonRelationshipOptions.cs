namespace Stripe
{
    using Newtonsoft.Json;

    public class TokenPersonRelationshipOptions : INestedOptions
    {
        /// <summary>
        /// Whether the person is a director of the account's legal entity. Currently only required
        /// for accounts in the EU. Directors are typically members of the governing board of the
        /// company, or responsible for ensuring the company meets its regulatory obligations.
        /// </summary>
        [JsonProperty("director")]
        public bool? Director { get; set; }

        /// <summary>
        /// Whether the person has significant responsibility to control, manage, or direct the
        /// organization.
        /// </summary>
        [JsonProperty("executive")]
        public bool? Executive { get; set; }

        /// <summary>
        /// Whether the person is an owner of the account’s legal entity.
        /// </summary>
        [JsonProperty("owner")]
        public bool? Owner { get; set; }

        /// <summary>
        /// The percent owned by the person of the account's legal entity.
        /// </summary>
        [JsonProperty("percent_ownership")]
        public decimal? PercentOwnership { get; set; }

        /// <summary>
        /// Whether the person is authorized as the primary representative of the account. This is
        /// the person nominated by the business to provide information about themselves, and
        /// general information about the account. There can only be one representative at any given
        /// time. At the time the account is created, this person should be set to the person
        /// responsible for opening the account.
        /// </summary>
        [JsonProperty("representative")]
        public bool? Representative { get; set; }

        /// <summary>
        /// The person's title (e.g., CEO, Support Engineer).
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
