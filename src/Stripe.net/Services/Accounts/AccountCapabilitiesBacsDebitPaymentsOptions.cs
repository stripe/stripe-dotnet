namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCapabilitiesBacsDebitPaymentsOptions : INestedOptions
    {
        [JsonProperty("requested")]
        public bool? Requested { get; set; }
    }
}
