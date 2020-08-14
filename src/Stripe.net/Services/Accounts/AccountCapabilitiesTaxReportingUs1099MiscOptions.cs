namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCapabilitiesTaxReportingUs1099MiscOptions : INestedOptions
    {
        [JsonProperty("requested")]
        public bool? Requested { get; set; }
    }
}
