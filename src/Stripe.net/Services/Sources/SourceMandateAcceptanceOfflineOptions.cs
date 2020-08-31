namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceMandateAcceptanceOfflineOptions : INestedOptions
    {
        /// <summary>
        /// An email to contact you with if a copy of the mandate is requested, required if
        /// <c>type</c> is <c>offline</c>.
        /// </summary>
        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }
    }
}
