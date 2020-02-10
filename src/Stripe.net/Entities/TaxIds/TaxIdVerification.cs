namespace Stripe
{
    using Newtonsoft.Json;

    public class TaxIdVerification : StripeEntity<TaxIdVerification>
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("verified_address")]
        public string VerifiedAddress { get; set; }

        [JsonProperty("verified_name")]
        public string VerifiedName { get; set; }
    }
}
