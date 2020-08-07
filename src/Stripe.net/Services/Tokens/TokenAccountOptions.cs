namespace Stripe
{
    using Newtonsoft.Json;

    public class TokenAccountOptions : INestedOptions
    {
        [JsonProperty("business_type")]
        public string BusinessType { get; set; }

        [JsonProperty("company")]
        public TokenAccountCompanyOptions Company { get; set; }

        [JsonProperty("individual")]
        public TokenAccountIndividualOptions Individual { get; set; }

        [JsonProperty("tos_shown_and_accepted")]
        public bool? TosShownAndAccepted { get; set; }
    }
}
