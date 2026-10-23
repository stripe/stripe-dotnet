// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSessionCreateComponentsOptions : INestedOptions
    {
        /// <summary>
        /// Settings for the Account Management embedded component.
        /// </summary>
        [JsonProperty("account_management")]
        [STJS.JsonPropertyName("account_management")]
        public AccountSessionCreateComponentsAccountManagementOptions AccountManagement { get; set; }

        /// <summary>
        /// Settings for the Account Onboarding embedded component.
        /// </summary>
        [JsonProperty("account_onboarding")]
        [STJS.JsonPropertyName("account_onboarding")]
        public AccountSessionCreateComponentsAccountOnboardingOptions AccountOnboarding { get; set; }

        /// <summary>
        /// Settings for the Agentic Commerce Settings embedded component.
        /// </summary>
        [JsonProperty("agentic_commerce_settings")]
        [STJS.JsonPropertyName("agentic_commerce_settings")]
        public AccountSessionCreateComponentsAgenticCommerceSettingsOptions AgenticCommerceSettings { get; set; }

        /// <summary>
        /// Settings for the App Install embedded component.
        /// </summary>
        [JsonProperty("app_install")]
        [STJS.JsonPropertyName("app_install")]
        public AccountSessionCreateComponentsAppInstallOptions AppInstall { get; set; }

        /// <summary>
        /// Settings for the App Viewport embedded component.
        /// </summary>
        [JsonProperty("app_viewport")]
        [STJS.JsonPropertyName("app_viewport")]
        public AccountSessionCreateComponentsAppViewportOptions AppViewport { get; set; }

        /// <summary>
        /// Settings for the Balance Report embedded component.
        /// </summary>
        [JsonProperty("balance_report")]
        [STJS.JsonPropertyName("balance_report")]
        public AccountSessionCreateComponentsBalanceReportOptions BalanceReport { get; set; }

        /// <summary>
        /// Settings for the Balances embedded component.
        /// </summary>
        [JsonProperty("balances")]
        [STJS.JsonPropertyName("balances")]
        public AccountSessionCreateComponentsBalancesOptions Balances { get; set; }

        /// <summary>
        /// Settings for the Bills embedded component.
        /// </summary>
        [JsonProperty("bills")]
        [STJS.JsonPropertyName("bills")]
        public AccountSessionCreateComponentsBillsOptions Bills { get; set; }

        /// <summary>
        /// Settings for the Capital Financing embedded component.
        /// </summary>
        [JsonProperty("capital_financing")]
        [STJS.JsonPropertyName("capital_financing")]
        public AccountSessionCreateComponentsCapitalFinancingOptions CapitalFinancing { get; set; }

        /// <summary>
        /// Settings for the Capital Financing Application embedded component.
        /// </summary>
        [JsonProperty("capital_financing_application")]
        [STJS.JsonPropertyName("capital_financing_application")]
        public AccountSessionCreateComponentsCapitalFinancingApplicationOptions CapitalFinancingApplication { get; set; }

        /// <summary>
        /// Settings for the Capital Financing Promotion embedded component.
        /// </summary>
        [JsonProperty("capital_financing_promotion")]
        [STJS.JsonPropertyName("capital_financing_promotion")]
        public AccountSessionCreateComponentsCapitalFinancingPromotionOptions CapitalFinancingPromotion { get; set; }

        /// <summary>
        /// Settings for the Check Scanning embedded component.
        /// </summary>
        [JsonProperty("check_scanning")]
        [STJS.JsonPropertyName("check_scanning")]
        public AccountSessionCreateComponentsCheckScanningOptions CheckScanning { get; set; }

        /// <summary>
        /// Settings for the Disputes List embedded component.
        /// </summary>
        [JsonProperty("disputes_list")]
        [STJS.JsonPropertyName("disputes_list")]
        public AccountSessionCreateComponentsDisputesListOptions DisputesList { get; set; }

        /// <summary>
        /// Settings for the Documents embedded component.
        /// </summary>
        [JsonProperty("documents")]
        [STJS.JsonPropertyName("documents")]
        public AccountSessionCreateComponentsDocumentsOptions Documents { get; set; }

        /// <summary>
        /// Settings for the Export Tax Transactions embedded component.
        /// </summary>
        [JsonProperty("export_tax_transactions")]
        [STJS.JsonPropertyName("export_tax_transactions")]
        public AccountSessionCreateComponentsExportTaxTransactionsOptions ExportTaxTransactions { get; set; }

        /// <summary>
        /// Settings for the Financial Account Rewards embedded component.
        /// </summary>
        [JsonProperty("financial_account_rewards")]
        [STJS.JsonPropertyName("financial_account_rewards")]
        public AccountSessionCreateComponentsFinancialAccountRewardsOptions FinancialAccountRewards { get; set; }

        /// <summary>
        /// Settings for the Financial Accounts embedded component.
        /// </summary>
        [JsonProperty("financial_accounts")]
        [STJS.JsonPropertyName("financial_accounts")]
        public AccountSessionCreateComponentsFinancialAccountsOptions FinancialAccounts { get; set; }

        /// <summary>
        /// Settings for the Financial Accounts Transactions embedded component.
        /// </summary>
        [JsonProperty("financial_accounts_transactions")]
        [STJS.JsonPropertyName("financial_accounts_transactions")]
        public AccountSessionCreateComponentsFinancialAccountsTransactionsOptions FinancialAccountsTransactions { get; set; }

        /// <summary>
        /// Settings for the Instant Payouts Promotion embedded component.
        /// </summary>
        [JsonProperty("instant_payouts_promotion")]
        [STJS.JsonPropertyName("instant_payouts_promotion")]
        public AccountSessionCreateComponentsInstantPayoutsPromotionOptions InstantPayoutsPromotion { get; set; }

        /// <summary>
        /// Settings for the Invoice History embedded component.
        /// </summary>
        [JsonProperty("invoice_history")]
        [STJS.JsonPropertyName("invoice_history")]
        public AccountSessionCreateComponentsInvoiceHistoryOptions InvoiceHistory { get; set; }

        /// <summary>
        /// Settings for the Issuing Card embedded component.
        /// </summary>
        [JsonProperty("issuing_card")]
        [STJS.JsonPropertyName("issuing_card")]
        public AccountSessionCreateComponentsIssuingCardOptions IssuingCard { get; set; }

        /// <summary>
        /// Settings for the Issuing Cards List embedded component.
        /// </summary>
        [JsonProperty("issuing_cards_list")]
        [STJS.JsonPropertyName("issuing_cards_list")]
        public AccountSessionCreateComponentsIssuingCardsListOptions IssuingCardsList { get; set; }

        /// <summary>
        /// Settings for the Network Cost Passthrough Report embedded component.
        /// </summary>
        [JsonProperty("network_cost_passthrough_report")]
        [STJS.JsonPropertyName("network_cost_passthrough_report")]
        public AccountSessionCreateComponentsNetworkCostPassthroughReportOptions NetworkCostPassthroughReport { get; set; }

        /// <summary>
        /// Settings for the Notification Banner embedded component.
        /// </summary>
        [JsonProperty("notification_banner")]
        [STJS.JsonPropertyName("notification_banner")]
        public AccountSessionCreateComponentsNotificationBannerOptions NotificationBanner { get; set; }

        /// <summary>
        /// Settings for the Payment Details embedded component.
        /// </summary>
        [JsonProperty("payment_details")]
        [STJS.JsonPropertyName("payment_details")]
        public AccountSessionCreateComponentsPaymentDetailsOptions PaymentDetails { get; set; }

        /// <summary>
        /// Settings for the Payment Disputes embedded component.
        /// </summary>
        [JsonProperty("payment_disputes")]
        [STJS.JsonPropertyName("payment_disputes")]
        public AccountSessionCreateComponentsPaymentDisputesOptions PaymentDisputes { get; set; }

        /// <summary>
        /// Settings for the Payment Method Settings embedded component.
        /// </summary>
        [JsonProperty("payment_method_settings")]
        [STJS.JsonPropertyName("payment_method_settings")]
        public AccountSessionCreateComponentsPaymentMethodSettingsOptions PaymentMethodSettings { get; set; }

        /// <summary>
        /// Settings for the Payments embedded component.
        /// </summary>
        [JsonProperty("payments")]
        [STJS.JsonPropertyName("payments")]
        public AccountSessionCreateComponentsPaymentsOptions Payments { get; set; }

        /// <summary>
        /// Settings for the Payout Details embedded component.
        /// </summary>
        [JsonProperty("payout_details")]
        [STJS.JsonPropertyName("payout_details")]
        public AccountSessionCreateComponentsPayoutDetailsOptions PayoutDetails { get; set; }

        /// <summary>
        /// Settings for the Payout Reconciliation Report embedded component.
        /// </summary>
        [JsonProperty("payout_reconciliation_report")]
        [STJS.JsonPropertyName("payout_reconciliation_report")]
        public AccountSessionCreateComponentsPayoutReconciliationReportOptions PayoutReconciliationReport { get; set; }

        /// <summary>
        /// Settings for the Payouts embedded component.
        /// </summary>
        [JsonProperty("payouts")]
        [STJS.JsonPropertyName("payouts")]
        public AccountSessionCreateComponentsPayoutsOptions Payouts { get; set; }

        /// <summary>
        /// Settings for the Payouts List embedded component.
        /// </summary>
        [JsonProperty("payouts_list")]
        [STJS.JsonPropertyName("payouts_list")]
        public AccountSessionCreateComponentsPayoutsListOptions PayoutsList { get; set; }

        /// <summary>
        /// Settings for the Product Tax Code Selector embedded component.
        /// </summary>
        [JsonProperty("product_tax_code_selector")]
        [STJS.JsonPropertyName("product_tax_code_selector")]
        public AccountSessionCreateComponentsProductTaxCodeSelectorOptions ProductTaxCodeSelector { get; set; }

        /// <summary>
        /// Settings for the Reporting Chart embedded component.
        /// </summary>
        [JsonProperty("reporting_chart")]
        [STJS.JsonPropertyName("reporting_chart")]
        public AccountSessionCreateComponentsReportingChartOptions ReportingChart { get; set; }

        /// <summary>
        /// Settings for the Tax Registrations embedded component.
        /// </summary>
        [JsonProperty("tax_registrations")]
        [STJS.JsonPropertyName("tax_registrations")]
        public AccountSessionCreateComponentsTaxRegistrationsOptions TaxRegistrations { get; set; }

        /// <summary>
        /// Settings for the Tax Settings embedded component.
        /// </summary>
        [JsonProperty("tax_settings")]
        [STJS.JsonPropertyName("tax_settings")]
        public AccountSessionCreateComponentsTaxSettingsOptions TaxSettings { get; set; }

        /// <summary>
        /// Settings for the Tax Threshold Monitoring embedded component.
        /// </summary>
        [JsonProperty("tax_threshold_monitoring")]
        [STJS.JsonPropertyName("tax_threshold_monitoring")]
        public AccountSessionCreateComponentsTaxThresholdMonitoringOptions TaxThresholdMonitoring { get; set; }

        /// <summary>
        /// Settings for the Terminal Hardware Orders embedded component.
        /// </summary>
        [JsonProperty("terminal_hardware_orders")]
        [STJS.JsonPropertyName("terminal_hardware_orders")]
        public AccountSessionCreateComponentsTerminalHardwareOrdersOptions TerminalHardwareOrders { get; set; }

        /// <summary>
        /// Settings for the Terminal Hardware Shop embedded component.
        /// </summary>
        [JsonProperty("terminal_hardware_shop")]
        [STJS.JsonPropertyName("terminal_hardware_shop")]
        public AccountSessionCreateComponentsTerminalHardwareShopOptions TerminalHardwareShop { get; set; }
    }
}
