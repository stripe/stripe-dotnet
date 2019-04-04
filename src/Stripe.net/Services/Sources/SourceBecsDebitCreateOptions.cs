namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceBecsDebitCreateOptions : INestedOptions
    {
        [JsonProperty("bsb_number")]
        public string BsbNumber { get; set; }

        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }
    }
}
