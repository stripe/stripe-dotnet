namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCapabilitiesJcbPaymentsOptions : INestedOptions
    {
        [JsonProperty("requested")]
        public bool? Requested { get; set; }
    }
}
