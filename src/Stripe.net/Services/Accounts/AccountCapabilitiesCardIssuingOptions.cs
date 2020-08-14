namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCapabilitiesCardIssuingOptions : INestedOptions
    {
        [JsonProperty("requested")]
        public bool? Requested { get; set; }
    }
}
