namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsCardPaymentsOptions : INestedOptions
    {
        [JsonProperty("decline_on")]
        public AccountSettingsDeclineOnOptions DeclineOn { get; set; }

        [JsonProperty("statement_descriptor_prefix")]
        public string StatementDescriptorPrefix { get; set; }
    }
}
