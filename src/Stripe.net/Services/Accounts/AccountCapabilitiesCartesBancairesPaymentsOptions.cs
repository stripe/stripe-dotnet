namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCapabilitiesCartesBancairesPaymentsOptions : INestedOptions
    {
        [JsonProperty("requested")]
        public bool? Requested { get; set; }
    }
}
