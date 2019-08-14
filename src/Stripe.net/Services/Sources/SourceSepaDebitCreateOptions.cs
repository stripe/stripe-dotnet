namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceSepaDebitCreateOptions : INestedOptions
    {
        [JsonProperty("iban")]
        public string Iban { get; set; }

        [JsonProperty("ideal")]
        public string Ideal { get; set; }
    }
}
