namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCapabilitiesFpxPaymentsOptions : INestedOptions
    {
        [JsonProperty("requested")]
        public bool? Requested { get; set; }
    }
}
