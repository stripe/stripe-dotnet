namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentSingleUseOptions : INestedOptions
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
