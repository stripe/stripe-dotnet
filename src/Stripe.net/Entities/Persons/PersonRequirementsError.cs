namespace Stripe
{
    using Newtonsoft.Json;

    public class PersonRequirementsError : StripeEntity<PersonRequirementsError>
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("requirement")]
        public string Requirement { get; set; }
    }
}
