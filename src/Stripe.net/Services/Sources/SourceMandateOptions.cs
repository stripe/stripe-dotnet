namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceMandateOptions : INestedOptions
    {
        [JsonProperty("acceptance")]
        public SourceMandateAcceptanceOptions Acceptance { get; set; }
    }
}
