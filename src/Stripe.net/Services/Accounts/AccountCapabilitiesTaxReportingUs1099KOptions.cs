namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCapabilitiesTaxReportingUs1099KOptions : INestedOptions
    {
        [JsonProperty("requested")]
        public bool? Requested { get; set; }
    }
}
