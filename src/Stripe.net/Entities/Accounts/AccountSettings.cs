// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettings : StripeEntity<AccountSettings>
    {
        [JsonProperty("bacs_debit_payments")]
        public AccountSettingsBacsDebitPayments BacsDebitPayments { get; set; }

        [JsonProperty("bank_bca_onboarding")]
        public AccountSettingsBankBcaOnboarding BankBcaOnboarding { get; set; }

        [JsonProperty("branding")]
        public AccountSettingsBranding Branding { get; set; }

        [JsonProperty("capital")]
        public AccountSettingsCapital Capital { get; set; }

        [JsonProperty("card_issuing")]
        public AccountSettingsCardIssuing CardIssuing { get; set; }

        [JsonProperty("card_payments")]
        public AccountSettingsCardPayments CardPayments { get; set; }

        [JsonProperty("dashboard")]
        public AccountSettingsDashboard Dashboard { get; set; }

        [JsonProperty("invoices")]
        public AccountSettingsInvoices Invoices { get; set; }

        [JsonProperty("payments")]
        public AccountSettingsPayments Payments { get; set; }

        [JsonProperty("payouts")]
        public AccountSettingsPayouts Payouts { get; set; }

        [JsonProperty("sepa_debit_payments")]
        public AccountSettingsSepaDebitPayments SepaDebitPayments { get; set; }

        [JsonProperty("tax_forms")]
        public AccountSettingsTaxForms TaxForms { get; set; }

        [JsonProperty("treasury")]
        public AccountSettingsTreasury Treasury { get; set; }
    }
}
