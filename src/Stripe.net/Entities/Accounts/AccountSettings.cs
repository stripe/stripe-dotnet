// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettings : StripeEntity<AccountSettings>
    {
        [JsonProperty("bacs_debit_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bacs_debit_payments")]
#endif
        public AccountSettingsBacsDebitPayments BacsDebitPayments { get; set; }

        [JsonProperty("bank_bca_onboarding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_bca_onboarding")]
#endif
        public AccountSettingsBankBcaOnboarding BankBcaOnboarding { get; set; }

        [JsonProperty("branding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("branding")]
#endif
        public AccountSettingsBranding Branding { get; set; }

        [JsonProperty("card_issuing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_issuing")]
#endif
        public AccountSettingsCardIssuing CardIssuing { get; set; }

        [JsonProperty("card_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_payments")]
#endif
        public AccountSettingsCardPayments CardPayments { get; set; }

        [JsonProperty("dashboard")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dashboard")]
#endif
        public AccountSettingsDashboard Dashboard { get; set; }

        [JsonProperty("invoices")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoices")]
#endif
        public AccountSettingsInvoices Invoices { get; set; }

        [JsonProperty("payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payments")]
#endif
        public AccountSettingsPayments Payments { get; set; }

        [JsonProperty("payouts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payouts")]
#endif
        public AccountSettingsPayouts Payouts { get; set; }

        [JsonProperty("paypay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypay_payments")]
#endif
        public AccountSettingsPaypayPayments PaypayPayments { get; set; }

        [JsonProperty("sepa_debit_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_debit_payments")]
#endif
        public AccountSettingsSepaDebitPayments SepaDebitPayments { get; set; }

        [JsonProperty("tax_forms")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_forms")]
#endif
        public AccountSettingsTaxForms TaxForms { get; set; }

        [JsonProperty("treasury")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("treasury")]
#endif
        public AccountSettingsTreasury Treasury { get; set; }
    }
}
