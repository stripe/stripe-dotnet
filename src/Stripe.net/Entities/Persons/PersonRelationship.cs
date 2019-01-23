namespace Stripe
{
    using Newtonsoft.Json;

    public class PersonRelationship : StripeEntity<PersonRelationship>
    {
        /// <summary>
        /// Whether the person opened the account. This person provides information about
        /// themselves, and general information about the account.
        /// </summary>
        [JsonProperty("account_opener")]
        public bool AccountOpener { get; set; }

        /// <summary>
        /// Whether the person is a director of the account’s legal entity..
        /// </summary>
        [JsonProperty("director")]
        public bool Director { get; set; }

        /// <summary>
        /// Whether the person is an owner of the account’s legal entity..
        /// </summary>
        [JsonProperty("owner")]
        public bool Owner { get; set; }

        /// <summary>
        /// The percent owned by the person of the account’s legal entity.
        /// </summary>
        [JsonProperty("percent_ownership")]
        public decimal? PercentOwnership { get; set; }

        /// <summary>
        /// The person’s title (e.g., CEO, Support Engineer).
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
