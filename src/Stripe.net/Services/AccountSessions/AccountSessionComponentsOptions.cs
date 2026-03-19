// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSessionComponentsOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/account-management/">account
        /// management</a> embedded component.
        /// </summary>
        [JsonProperty("account_management")]
        [STJS.JsonPropertyName("account_management")]
        public AccountSessionComponentsAccountManagementOptions AccountManagement { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/account-onboarding/">account
        /// onboarding</a> embedded component.
        /// </summary>
        [JsonProperty("account_onboarding")]
        [STJS.JsonPropertyName("account_onboarding")]
        public AccountSessionComponentsAccountOnboardingOptions AccountOnboarding { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/app-install/">app
        /// install</a> embedded component.
        /// </summary>
        [JsonProperty("app_install")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("app_install")]
#endif
        public AccountSessionComponentsAppInstallOptions AppInstall { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/app-viewport/">app
        /// viewport</a> embedded component.
        /// </summary>
        [JsonProperty("app_viewport")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("app_viewport")]
#endif
        public AccountSessionComponentsAppViewportOptions AppViewport { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/balances/">balances</a>
        /// embedded component.
        /// </summary>
        [JsonProperty("balances")]
        [STJS.JsonPropertyName("balances")]
        public AccountSessionComponentsBalancesOptions Balances { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/capital-financing/">Capital
        /// financing</a> embedded component.
        /// </summary>
        [JsonProperty("capital_financing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capital_financing")]
#endif
        public AccountSessionComponentsCapitalFinancingOptions CapitalFinancing { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/capital-financing-application/">Capital
        /// financing application</a> embedded component.
        /// </summary>
        [JsonProperty("capital_financing_application")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capital_financing_application")]
#endif
        public AccountSessionComponentsCapitalFinancingApplicationOptions CapitalFinancingApplication { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/capital-financing-promotion/">Capital
        /// financing promotion</a> embedded component.
        /// </summary>
        [JsonProperty("capital_financing_promotion")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capital_financing_promotion")]
#endif
        public AccountSessionComponentsCapitalFinancingPromotionOptions CapitalFinancingPromotion { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/capital-overview/">Capital
        /// overview</a> embedded component.
        /// </summary>
        [JsonProperty("capital_overview")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capital_overview")]
#endif
        public AccountSessionComponentsCapitalOverviewOptions CapitalOverview { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/disputes-list/">disputes
        /// list</a> embedded component.
        /// </summary>
        [JsonProperty("disputes_list")]
        [STJS.JsonPropertyName("disputes_list")]
        public AccountSessionComponentsDisputesListOptions DisputesList { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/documents/">documents</a>
        /// embedded component.
        /// </summary>
        [JsonProperty("documents")]
        [STJS.JsonPropertyName("documents")]
        public AccountSessionComponentsDocumentsOptions Documents { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/export-tax-transactions/">export
        /// tax transactions</a> embedded component.
        /// </summary>
        [JsonProperty("export_tax_transactions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("export_tax_transactions")]
#endif
        public AccountSessionComponentsExportTaxTransactionsOptions ExportTaxTransactions { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/financial-account/">financial
        /// account</a> embedded component.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public AccountSessionComponentsFinancialAccountOptions FinancialAccount { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/financial-account-transactions/">financial
        /// account transactions</a> embedded component.
        /// </summary>
        [JsonProperty("financial_account_transactions")]
        [STJS.JsonPropertyName("financial_account_transactions")]
        public AccountSessionComponentsFinancialAccountTransactionsOptions FinancialAccountTransactions { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/instant-payouts-promotion/">instant
        /// payouts promotion</a> embedded component.
        /// </summary>
        [JsonProperty("instant_payouts_promotion")]
        [STJS.JsonPropertyName("instant_payouts_promotion")]
        public AccountSessionComponentsInstantPayoutsPromotionOptions InstantPayoutsPromotion { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/issuing-card/">issuing
        /// card</a> embedded component.
        /// </summary>
        [JsonProperty("issuing_card")]
        [STJS.JsonPropertyName("issuing_card")]
        public AccountSessionComponentsIssuingCardOptions IssuingCard { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/issuing-cards-list/">issuing
        /// cards list</a> embedded component.
        /// </summary>
        [JsonProperty("issuing_cards_list")]
        [STJS.JsonPropertyName("issuing_cards_list")]
        public AccountSessionComponentsIssuingCardsListOptions IssuingCardsList { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/notification-banner/">notification
        /// banner</a> embedded component.
        /// </summary>
        [JsonProperty("notification_banner")]
        [STJS.JsonPropertyName("notification_banner")]
        public AccountSessionComponentsNotificationBannerOptions NotificationBanner { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/payment-details/">payment
        /// details</a> embedded component.
        /// </summary>
        [JsonProperty("payment_details")]
        [STJS.JsonPropertyName("payment_details")]
        public AccountSessionComponentsPaymentDetailsOptions PaymentDetails { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/payment-disputes/">payment
        /// disputes</a> embedded component.
        /// </summary>
        [JsonProperty("payment_disputes")]
        [STJS.JsonPropertyName("payment_disputes")]
        public AccountSessionComponentsPaymentDisputesOptions PaymentDisputes { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/payment-method-settings/">payment
        /// method settings</a> embedded component.
        /// </summary>
        [JsonProperty("payment_method_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_settings")]
#endif
        public AccountSessionComponentsPaymentMethodSettingsOptions PaymentMethodSettings { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/payments/">payments</a>
        /// embedded component.
        /// </summary>
        [JsonProperty("payments")]
        [STJS.JsonPropertyName("payments")]
        public AccountSessionComponentsPaymentsOptions Payments { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/payout-details/">payout
        /// details</a> embedded component.
        /// </summary>
        [JsonProperty("payout_details")]
        [STJS.JsonPropertyName("payout_details")]
        public AccountSessionComponentsPayoutDetailsOptions PayoutDetails { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/payouts/">payouts</a>
        /// embedded component.
        /// </summary>
        [JsonProperty("payouts")]
        [STJS.JsonPropertyName("payouts")]
        public AccountSessionComponentsPayoutsOptions Payouts { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/payouts-list/">payouts
        /// list</a> embedded component.
        /// </summary>
        [JsonProperty("payouts_list")]
        [STJS.JsonPropertyName("payouts_list")]
        public AccountSessionComponentsPayoutsListOptions PayoutsList { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/product-tax-code-selector/">product
        /// tax code selector</a> embedded component.
        /// </summary>
        [JsonProperty("product_tax_code_selector")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product_tax_code_selector")]
#endif
        public AccountSessionComponentsProductTaxCodeSelectorOptions ProductTaxCodeSelector { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/recipients/">recipients</a>
        /// embedded component.
        /// </summary>
        [JsonProperty("recipients")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recipients")]
#endif
        public AccountSessionComponentsRecipientsOptions Recipients { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/reporting-chart/">reporting
        /// chart</a> embedded component.
        /// </summary>
        [JsonProperty("reporting_chart")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reporting_chart")]
#endif
        public AccountSessionComponentsReportingChartOptions ReportingChart { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/tax-registrations/">tax
        /// registrations</a> embedded component.
        /// </summary>
        [JsonProperty("tax_registrations")]
        [STJS.JsonPropertyName("tax_registrations")]
        public AccountSessionComponentsTaxRegistrationsOptions TaxRegistrations { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/tax-settings/">tax
        /// settings</a> embedded component.
        /// </summary>
        [JsonProperty("tax_settings")]
        [STJS.JsonPropertyName("tax_settings")]
        public AccountSessionComponentsTaxSettingsOptions TaxSettings { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/tax-threshold-monitoring/">tax
        /// threshold monitoring</a> embedded component.
        /// </summary>
        [JsonProperty("tax_threshold_monitoring")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_threshold_monitoring")]
#endif
        public AccountSessionComponentsTaxThresholdMonitoringOptions TaxThresholdMonitoring { get; set; }
    }
}
