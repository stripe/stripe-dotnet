namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsPayouts : StripeEntity<AccountSettingsPayouts>
    {
        [JsonProperty("debit_negative_balances")]
        public bool DebitNegativeBalances { get; set; }

        [JsonProperty("schedule")]
        public AccountSettingsPayoutsSchedule Schedule { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
