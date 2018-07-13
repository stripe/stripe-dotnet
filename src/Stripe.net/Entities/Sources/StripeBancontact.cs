namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeBancontact : StripeEntity
    {
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("bic")]
        public string Bic { get; set; }

        [JsonProperty("preferred_language")]
        public string PreferredLanguage { get; set; }
    }
}
