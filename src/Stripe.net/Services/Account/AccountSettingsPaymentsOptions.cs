namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsPaymentsOptions : INestedOptions
    {
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
