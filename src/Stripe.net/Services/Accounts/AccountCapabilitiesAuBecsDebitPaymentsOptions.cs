namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCapabilitiesAuBecsDebitPaymentsOptions : INestedOptions
    {
        [JsonProperty("requested")]
        public bool? Requested { get; set; }
    }
}
