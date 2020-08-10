namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceCodeVerification : StripeEntity<SourceCodeVerification>
    {
        [JsonProperty("attempts_remaining")]
        public long AttemptsRemaining { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
