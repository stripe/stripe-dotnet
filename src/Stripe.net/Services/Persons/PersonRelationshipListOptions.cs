namespace Stripe
{
    using Newtonsoft.Json;

    public class PersonRelationshipListOptions : INestedOptions
    {
        [JsonProperty("account_opener")]
        public bool? AccountOpener { get; set; }

        [JsonProperty("director")]
        public bool? Director { get; set; }

        [JsonProperty("owner")]
        public bool? Owner { get; set; }
    }
}
