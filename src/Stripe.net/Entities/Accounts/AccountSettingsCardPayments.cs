namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsCardPayments : StripeEntity<AccountSettingsCardPayments>
    {
        [JsonProperty("decline_on")]
        public AccountSettingsDeclineOn DeclineOn { get; set; }

        /// <summary>
        /// The default text that appears on credit card statements when a charge is made. This
        /// field prefixes any dynamic <c>statement_descriptor</c> specified on the charge.
        /// <c>statement_descriptor_prefix</c> is useful for maximizing descriptor space for the
        /// dynamic portion.
        /// </summary>
        [JsonProperty("statement_descriptor_prefix")]
        public string StatementDescriptorPrefix { get; set; }
    }
}
