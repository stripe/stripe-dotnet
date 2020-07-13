namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsOptions : INestedOptions
    {
        [JsonProperty("branding")]
        public AccountSettingsBrandingOptions Branding { get; set; }

        [JsonProperty("card_payments")]
        public AccountSettingsCardPaymentsOptions CardPayments { get; set; }

        [JsonProperty("payments")]
        public AccountSettingsPaymentsOptions Payments { get; set; }

        [JsonProperty("payouts")]
        public AccountSettingsPayoutsOptions Payouts { get; set; }
    }
}
