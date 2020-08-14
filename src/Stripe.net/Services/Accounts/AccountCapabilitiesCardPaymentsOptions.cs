namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCapabilitiesCardPaymentsOptions : INestedOptions
    {
        [JsonProperty("requested")]
        public bool? Requested { get; set; }
    }
}
