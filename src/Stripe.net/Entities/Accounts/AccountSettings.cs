namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountSettings : StripeEntity<AccountSettings>
    {
        [JsonProperty("branding")]
        public AccountSettingsBranding Branding { get; set; }

        [JsonProperty("card_payments")]
        public AccountSettingsCardPayments CardPayments { get; set; }

        [JsonProperty("dashboard")]
        public AccountSettingsDashboard Dashboard { get; set; }

        [JsonProperty("payments")]
        public AccountSettingsPayments Payments { get; set; }

        [JsonProperty("payouts")]
        public AccountSettingsPayouts Payouts { get; set; }
    }
}
