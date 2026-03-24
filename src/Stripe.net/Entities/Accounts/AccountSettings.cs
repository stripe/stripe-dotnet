// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSettings : StripeEntity<AccountSettings>
    {
        [JsonProperty("bacs_debit_payments")]
        [STJS.JsonPropertyName("bacs_debit_payments")]
        public AccountSettingsBacsDebitPayments BacsDebitPayments { get; set; }

        [JsonProperty("bank_bca_onboarding")]
        [STJS.JsonPropertyName("bank_bca_onboarding")]
        public AccountSettingsBankBcaOnboarding BankBcaOnboarding { get; set; }

        [JsonProperty("branding")]
        [STJS.JsonPropertyName("branding")]
        public AccountSettingsBranding Branding { get; set; }

        [JsonProperty("card_issuing")]
        [STJS.JsonPropertyName("card_issuing")]
        public AccountSettingsCardIssuing CardIssuing { get; set; }

        [JsonProperty("card_payments")]
        [STJS.JsonPropertyName("card_payments")]
        public AccountSettingsCardPayments CardPayments { get; set; }

        [JsonProperty("dashboard")]
        [STJS.JsonPropertyName("dashboard")]
        public AccountSettingsDashboard Dashboard { get; set; }

        [JsonProperty("invoices")]
        [STJS.JsonPropertyName("invoices")]
        public AccountSettingsInvoices Invoices { get; set; }

        [JsonProperty("payments")]
        [STJS.JsonPropertyName("payments")]
        public AccountSettingsPayments Payments { get; set; }

        [JsonProperty("payouts")]
        [STJS.JsonPropertyName("payouts")]
        public AccountSettingsPayouts Payouts { get; set; }

        [JsonProperty("paypay_payments")]
        [STJS.JsonPropertyName("paypay_payments")]
        public AccountSettingsPaypayPayments PaypayPayments { get; set; }

        [JsonProperty("sepa_debit_payments")]
        [STJS.JsonPropertyName("sepa_debit_payments")]
        public AccountSettingsSepaDebitPayments SepaDebitPayments { get; set; }

        [JsonProperty("smart_disputes")]
        [STJS.JsonPropertyName("smart_disputes")]
        public AccountSettingsSmartDisputes SmartDisputes { get; set; }

        [JsonProperty("tax_forms")]
        [STJS.JsonPropertyName("tax_forms")]
        public AccountSettingsTaxForms TaxForms { get; set; }

        [JsonProperty("treasury")]
        [STJS.JsonPropertyName("treasury")]
        public AccountSettingsTreasury Treasury { get; set; }
    }
}
