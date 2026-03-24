// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Settings specific to Bacs Direct Debit payments.
        /// </summary>
        [JsonProperty("bacs_debit_payments")]
        [STJS.JsonPropertyName("bacs_debit_payments")]
        public AccountSettingsBacsDebitPaymentsOptions BacsDebitPayments { get; set; }

        /// <summary>
        /// Settings specific to bank BCA onboarding for Indonesia bank transfers payments method.
        /// </summary>
        [JsonProperty("bank_bca_onboarding")]
        [STJS.JsonPropertyName("bank_bca_onboarding")]
        public AccountSettingsBankBcaOnboardingOptions BankBcaOnboarding { get; set; }

        /// <summary>
        /// Settings used to apply the account's branding to email receipts, invoices, Checkout, and
        /// other products.
        /// </summary>
        [JsonProperty("branding")]
        [STJS.JsonPropertyName("branding")]
        public AccountSettingsBrandingOptions Branding { get; set; }

        /// <summary>
        /// Settings specific to the account's use of the Capital product.
        /// </summary>
        [JsonProperty("capital")]
        [STJS.JsonPropertyName("capital")]
        public AccountSettingsCapitalOptions Capital { get; set; }

        /// <summary>
        /// Settings specific to the account's use of the Card Issuing product.
        /// </summary>
        [JsonProperty("card_issuing")]
        [STJS.JsonPropertyName("card_issuing")]
        public AccountSettingsCardIssuingOptions CardIssuing { get; set; }

        /// <summary>
        /// Settings specific to card charging on the account.
        /// </summary>
        [JsonProperty("card_payments")]
        [STJS.JsonPropertyName("card_payments")]
        public AccountSettingsCardPaymentsOptions CardPayments { get; set; }

        /// <summary>
        /// Settings specific to the account's use of Invoices.
        /// </summary>
        [JsonProperty("invoices")]
        [STJS.JsonPropertyName("invoices")]
        public AccountSettingsInvoicesOptions Invoices { get; set; }

        /// <summary>
        /// Settings that apply across payment methods for charging on the account.
        /// </summary>
        [JsonProperty("payments")]
        [STJS.JsonPropertyName("payments")]
        public AccountSettingsPaymentsOptions Payments { get; set; }

        /// <summary>
        /// Settings specific to the account's payouts.
        /// </summary>
        [JsonProperty("payouts")]
        [STJS.JsonPropertyName("payouts")]
        public AccountSettingsPayoutsOptions Payouts { get; set; }

        /// <summary>
        /// Settings specific to the PayPay payments method.
        /// </summary>
        [JsonProperty("paypay_payments")]
        [STJS.JsonPropertyName("paypay_payments")]
        public AccountSettingsPaypayPaymentsOptions PaypayPayments { get; set; }

        /// <summary>
        /// Settings specific to the account's use of Smart Disputes.
        /// </summary>
        [JsonProperty("smart_disputes")]
        [STJS.JsonPropertyName("smart_disputes")]
        public AccountSettingsSmartDisputesOptions SmartDisputes { get; set; }

        /// <summary>
        /// Settings specific to the account's tax forms.
        /// </summary>
        [JsonProperty("tax_forms")]
        [STJS.JsonPropertyName("tax_forms")]
        public AccountSettingsTaxFormsOptions TaxForms { get; set; }

        /// <summary>
        /// Settings specific to the account's Treasury FinancialAccounts.
        /// </summary>
        [JsonProperty("treasury")]
        [STJS.JsonPropertyName("treasury")]
        public AccountSettingsTreasuryOptions Treasury { get; set; }
    }
}
