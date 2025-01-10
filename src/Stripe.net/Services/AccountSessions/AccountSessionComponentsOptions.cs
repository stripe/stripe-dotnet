// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSessionComponentsOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for the account management embedded component.
        /// </summary>
        [JsonProperty("account_management")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_management")]
#endif
        public AccountSessionComponentsAccountManagementOptions AccountManagement { get; set; }

        /// <summary>
        /// Configuration for the account onboarding embedded component.
        /// </summary>
        [JsonProperty("account_onboarding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_onboarding")]
#endif
        public AccountSessionComponentsAccountOnboardingOptions AccountOnboarding { get; set; }

        /// <summary>
        /// Configuration for the app install component.
        /// </summary>
        [JsonProperty("app_install")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("app_install")]
#endif
        public AccountSessionComponentsAppInstallOptions AppInstall { get; set; }

        /// <summary>
        /// Configuration for the app viewport component.
        /// </summary>
        [JsonProperty("app_viewport")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("app_viewport")]
#endif
        public AccountSessionComponentsAppViewportOptions AppViewport { get; set; }

        /// <summary>
        /// Configuration for the balances embedded component.
        /// </summary>
        [JsonProperty("balances")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balances")]
#endif
        public AccountSessionComponentsBalancesOptions Balances { get; set; }

        /// <summary>
        /// Configuration for the capital financing embedded component.
        /// </summary>
        [JsonProperty("capital_financing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capital_financing")]
#endif
        public AccountSessionComponentsCapitalFinancingOptions CapitalFinancing { get; set; }

        /// <summary>
        /// Configuration for the capital financing application embedded component.
        /// </summary>
        [JsonProperty("capital_financing_application")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capital_financing_application")]
#endif
        public AccountSessionComponentsCapitalFinancingApplicationOptions CapitalFinancingApplication { get; set; }

        /// <summary>
        /// Configuration for the capital financing promotion embedded component.
        /// </summary>
        [JsonProperty("capital_financing_promotion")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capital_financing_promotion")]
#endif
        public AccountSessionComponentsCapitalFinancingPromotionOptions CapitalFinancingPromotion { get; set; }

        /// <summary>
        /// Configuration for the capital overview embedded component.
        /// </summary>
        [JsonProperty("capital_overview")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capital_overview")]
#endif
        public AccountSessionComponentsCapitalOverviewOptions CapitalOverview { get; set; }

        /// <summary>
        /// Configuration for the documents embedded component.
        /// </summary>
        [JsonProperty("documents")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("documents")]
#endif
        public AccountSessionComponentsDocumentsOptions Documents { get; set; }

        /// <summary>
        /// Configuration for the financial account embedded component.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public AccountSessionComponentsFinancialAccountOptions FinancialAccount { get; set; }

        /// <summary>
        /// Configuration for the financial account transactions embedded component.
        /// </summary>
        [JsonProperty("financial_account_transactions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account_transactions")]
#endif
        public AccountSessionComponentsFinancialAccountTransactionsOptions FinancialAccountTransactions { get; set; }

        /// <summary>
        /// Configuration for the issuing card embedded component.
        /// </summary>
        [JsonProperty("issuing_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuing_card")]
#endif
        public AccountSessionComponentsIssuingCardOptions IssuingCard { get; set; }

        /// <summary>
        /// Configuration for the issuing cards list embedded component.
        /// </summary>
        [JsonProperty("issuing_cards_list")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuing_cards_list")]
#endif
        public AccountSessionComponentsIssuingCardsListOptions IssuingCardsList { get; set; }

        /// <summary>
        /// Configuration for the notification banner embedded component.
        /// </summary>
        [JsonProperty("notification_banner")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("notification_banner")]
#endif
        public AccountSessionComponentsNotificationBannerOptions NotificationBanner { get; set; }

        /// <summary>
        /// Configuration for the payment details embedded component.
        /// </summary>
        [JsonProperty("payment_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_details")]
#endif
        public AccountSessionComponentsPaymentDetailsOptions PaymentDetails { get; set; }

        /// <summary>
        /// Configuration for the payment method settings embedded component.
        /// </summary>
        [JsonProperty("payment_method_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_settings")]
#endif
        public AccountSessionComponentsPaymentMethodSettingsOptions PaymentMethodSettings { get; set; }

        /// <summary>
        /// Configuration for the payments embedded component.
        /// </summary>
        [JsonProperty("payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payments")]
#endif
        public AccountSessionComponentsPaymentsOptions Payments { get; set; }

        /// <summary>
        /// Configuration for the payouts embedded component.
        /// </summary>
        [JsonProperty("payouts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payouts")]
#endif
        public AccountSessionComponentsPayoutsOptions Payouts { get; set; }

        /// <summary>
        /// Configuration for the payouts list embedded component.
        /// </summary>
        [JsonProperty("payouts_list")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payouts_list")]
#endif
        public AccountSessionComponentsPayoutsListOptions PayoutsList { get; set; }

        /// <summary>
        /// Configuration for the recipients component.
        /// </summary>
        [JsonProperty("recipients")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recipients")]
#endif
        public AccountSessionComponentsRecipientsOptions Recipients { get; set; }

        /// <summary>
        /// Configuration for the reporting chart embedded component.
        /// </summary>
        [JsonProperty("reporting_chart")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reporting_chart")]
#endif
        public AccountSessionComponentsReportingChartOptions ReportingChart { get; set; }

        /// <summary>
        /// Configuration for the tax registrations embedded component.
        /// </summary>
        [JsonProperty("tax_registrations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_registrations")]
#endif
        public AccountSessionComponentsTaxRegistrationsOptions TaxRegistrations { get; set; }

        /// <summary>
        /// Configuration for the tax settings embedded component.
        /// </summary>
        [JsonProperty("tax_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_settings")]
#endif
        public AccountSessionComponentsTaxSettingsOptions TaxSettings { get; set; }
    }
}
