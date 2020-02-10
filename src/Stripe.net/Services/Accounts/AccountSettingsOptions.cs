namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountSettingsOptions : INestedOptions
    {
        [JsonProperty("branding")]
        public AccountSettingsBrandingOptions Branding { get; set; }

        [JsonProperty("card_payments")]
        public AccountSettingsCardPaymentsOptions CardPayments { get; set; }

        [JsonProperty("dashboard")]
        public AccountSettingsDashboardOptions Dashboard { get; set; }

        [JsonProperty("payments")]
        public AccountSettingsPaymentsOptions Payments { get; set; }

        [JsonProperty("payouts")]
        public AccountSettingsPayoutsOptions Payouts { get; set; }
    }
}
