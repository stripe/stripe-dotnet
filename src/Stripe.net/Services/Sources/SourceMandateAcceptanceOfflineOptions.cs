namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceMandateAcceptanceOfflineOptions : INestedOptions
    {
        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }
    }
}
