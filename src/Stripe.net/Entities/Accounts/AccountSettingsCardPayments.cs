namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsCardPayments : StripeEntity<AccountSettingsCardPayments>
    {
        [JsonProperty("decline_on")]
        public AccountSettingsDeclineOn DeclineOn { get; set; }

        [JsonProperty("statement_descriptor_prefix")]
        public string StatementDescriptorPrefix { get; set; }
    }
}
