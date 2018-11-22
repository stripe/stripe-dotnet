namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsCharge : StripeEntity
    {
        [JsonProperty("decline_on")]
        public AccountSettingsChargeDeclineOn DeclineOn { get; set; }

        [JsonProperty("shortform_statement_descriptor_prefix")]
        public string ShortformStatementDescriptorPrefix { get; set; }

        [JsonProperty("statement_descriptor_prefix")]
        public string StatementDescriptorPrefix { get; set; }
    }
}
