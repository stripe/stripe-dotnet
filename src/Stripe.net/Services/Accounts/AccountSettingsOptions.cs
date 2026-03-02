// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Settings specific to Bacs Direct Debit payments.
        /// </summary>
        [JsonProperty("bacs_debit_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bacs_debit_payments")]
#endif
        public AccountSettingsBacsDebitPaymentsOptions BacsDebitPayments { get; set; }

        /// <summary>
        /// Settings specific to bank BCA onboarding for Indonesia bank transfers payments method.
        /// </summary>
        [JsonProperty("bank_bca_onboarding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_bca_onboarding")]
#endif
        public AccountSettingsBankBcaOnboardingOptions BankBcaOnboarding { get; set; }

        /// <summary>
        /// Settings used to apply the account's branding to email receipts, invoices, Checkout, and
        /// other products.
        /// </summary>
        [JsonProperty("branding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("branding")]
#endif
        public AccountSettingsBrandingOptions Branding { get; set; }

        /// <summary>
        /// Settings specific to the account's use of the Capital product.
        /// </summary>
        [JsonProperty("capital")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capital")]
#endif
        public AccountSettingsCapitalOptions Capital { get; set; }

        /// <summary>
        /// Settings specific to the account's use of the Card Issuing product.
        /// </summary>
        [JsonProperty("card_issuing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_issuing")]
#endif
        public AccountSettingsCardIssuingOptions CardIssuing { get; set; }

        /// <summary>
        /// Settings specific to card charging on the account.
        /// </summary>
        [JsonProperty("card_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_payments")]
#endif
        public AccountSettingsCardPaymentsOptions CardPayments { get; set; }

        /// <summary>
        /// Settings specific to the account's use of Invoices.
        /// </summary>
        [JsonProperty("invoices")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoices")]
#endif
        public AccountSettingsInvoicesOptions Invoices { get; set; }

        /// <summary>
        /// Settings that apply across payment methods for charging on the account.
        /// </summary>
        [JsonProperty("payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payments")]
#endif
        public AccountSettingsPaymentsOptions Payments { get; set; }

        /// <summary>
        /// Settings specific to the account's payouts.
        /// </summary>
        [JsonProperty("payouts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payouts")]
#endif
        public AccountSettingsPayoutsOptions Payouts { get; set; }

        /// <summary>
        /// Settings specific to the PayPay payments method.
        /// </summary>
        [JsonProperty("paypay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypay_payments")]
#endif
        public AccountSettingsPaypayPaymentsOptions PaypayPayments { get; set; }

        /// <summary>
        /// Settings specific to the account's use of Smart Disputes.
        /// </summary>
        [JsonProperty("smart_disputes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("smart_disputes")]
#endif
        public AccountSettingsSmartDisputesOptions SmartDisputes { get; set; }

        /// <summary>
        /// Settings specific to the account's tax forms.
        /// </summary>
        [JsonProperty("tax_forms")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_forms")]
#endif
        public AccountSettingsTaxFormsOptions TaxForms { get; set; }

        /// <summary>
        /// Settings specific to the account's Treasury FinancialAccounts.
        /// </summary>
        [JsonProperty("treasury")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("treasury")]
#endif
        public AccountSettingsTreasuryOptions Treasury { get; set; }
    }
}
