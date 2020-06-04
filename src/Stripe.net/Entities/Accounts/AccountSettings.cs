namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettings : StripeEntity<AccountSettings>
    {
        /// <summary>
        /// Settings specific to BACS debit charging on the account.
        /// </summary>
        [JsonProperty("bacs_debit_payments")]
        public AccountSettingsBacsDebitPayments BacsDebitPayments { get; set; }

        /// <summary>
        /// Settings used to apply the account’s branding to email receipts, invoices, Checkout,
        /// and other products.
        /// </summary>
        [JsonProperty("branding")]
        public AccountSettingsBranding Branding { get; set; }

        /// <summary>
        /// Settings specific to card charging on the account.
        /// </summary>
        [JsonProperty("card_payments")]
        public AccountSettingsCardPayments CardPayments { get; set; }

        /// <summary>
        /// Settings used to configure the account within the Stripe dashboard.
        /// </summary>
        [JsonProperty("dashboard")]
        public AccountSettingsDashboard Dashboard { get; set; }

        /// <summary>
        /// Settings that apply across payment methods for charging on the account.
        /// </summary>
        [JsonProperty("payments")]
        public AccountSettingsPayments Payments { get; set; }

        /// <summary>
        /// Settings specific to the account’s payouts.
        /// </summary>
        [JsonProperty("payouts")]
        public AccountSettingsPayouts Payouts { get; set; }

        /// <summary>
        /// Settings specific to SEPA Debit charging on the account.
        /// </summary>
        [JsonProperty("sepa_debit_payments")]
        public AccountSettingsSepaDebitPayments SepaDebitPayments { get; set; }
    }
}
