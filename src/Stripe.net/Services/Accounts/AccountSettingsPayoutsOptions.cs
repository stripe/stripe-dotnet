namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountSettingsPayoutsOptions : INestedOptions
    {
        [JsonProperty("debit_negative_balances")]
        public bool? DebitNegativeBalances { get; set; }

        [JsonProperty("schedule")]
        public AccountSettingsPayoutsScheduleOptions Schedule { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
