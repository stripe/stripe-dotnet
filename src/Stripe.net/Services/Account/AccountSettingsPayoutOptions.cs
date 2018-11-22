namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsPayoutOptions : INestedOptions
    {
        [JsonProperty("debit_negative_balances")]
        public bool? DebitNegativeBalances { get; set; }

        [JsonProperty("schedule")]
        public AccountSettingsPayoutScheduleOptions Schedule { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
