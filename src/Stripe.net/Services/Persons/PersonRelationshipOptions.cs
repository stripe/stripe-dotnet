namespace Stripe
{
    using Newtonsoft.Json;

    public class PersonRelationshipOptions : INestedOptions
    {
        [JsonProperty("account_opener")]
        public bool? AccountOpener { get; set; }

        [JsonProperty("director")]
        public bool? Director { get; set; }

        [JsonProperty("owner")]
        public bool? Owner { get; set; }

        [JsonProperty("percent_ownership")]
        public decimal? PercentOwnership { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
