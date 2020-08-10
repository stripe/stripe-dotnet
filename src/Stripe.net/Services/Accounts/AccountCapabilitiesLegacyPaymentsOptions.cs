namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCapabilitiesLegacyPaymentsOptions : INestedOptions
    {
        [JsonProperty("requested")]
        public bool? Requested { get; set; }
    }
}
