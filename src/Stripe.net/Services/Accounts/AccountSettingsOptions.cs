namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Settings used to apply the account's branding to email receipts, invoices, Checkout, and
        /// other products.
        /// </summary>
        [JsonProperty("branding")]
        public AccountSettingsBrandingOptions Branding { get; set; }

        /// <summary>
        /// Settings specific to card charging on the account.
        /// </summary>
        [JsonProperty("card_payments")]
        public AccountSettingsCardPaymentsOptions CardPayments { get; set; }

        /// <summary>
        /// Settings that apply across payment methods for charging on the account.
        /// </summary>
        [JsonProperty("payments")]
        public AccountSettingsPaymentsOptions Payments { get; set; }

        /// <summary>
        /// Settings specific to the account's payouts.
        /// </summary>
        [JsonProperty("payouts")]
        public AccountSettingsPayoutsOptions Payouts { get; set; }
    }
}
