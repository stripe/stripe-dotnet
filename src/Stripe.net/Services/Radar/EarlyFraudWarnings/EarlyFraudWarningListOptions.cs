namespace Stripe.Radar
{
    using Newtonsoft.Json;

    public class EarlyFraudWarningListOptions : ListOptions
    {
        [JsonProperty("charge")]
        public string Charge { get; set; }
    }
}
