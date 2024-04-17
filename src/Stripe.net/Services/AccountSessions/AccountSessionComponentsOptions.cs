// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionComponentsOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for the account management embedded component.
        /// </summary>
        [JsonProperty("account_management")]
        public AccountSessionComponentsAccountManagementOptions AccountManagement { get; set; }

        /// <summary>
        /// Configuration for the account onboarding embedded component.
        /// </summary>
        [JsonProperty("account_onboarding")]
        public AccountSessionComponentsAccountOnboardingOptions AccountOnboarding { get; set; }

        /// <summary>
        /// Configuration for the balances embedded component.
        /// </summary>
        [JsonProperty("balances")]
        public AccountSessionComponentsBalancesOptions Balances { get; set; }

        [JsonProperty("capital_financing_promotion")]
        public AccountSessionComponentsCapitalFinancingPromotionOptions CapitalFinancingPromotion { get; set; }

        /// <summary>
        /// Configuration for the capital overview embedded component.
        /// </summary>
        [JsonProperty("capital_overview")]
        public AccountSessionComponentsCapitalOverviewOptions CapitalOverview { get; set; }

        /// <summary>
        /// Configuration for the documents embedded component.
        /// </summary>
        [JsonProperty("documents")]
        public AccountSessionComponentsDocumentsOptions Documents { get; set; }

        /// <summary>
        /// Configuration for the financial account component.
        /// </summary>
        [JsonProperty("financial_account")]
        public AccountSessionComponentsFinancialAccountOptions FinancialAccount { get; set; }

        /// <summary>
        /// Configuration for the financial account transactions component.
        /// </summary>
        [JsonProperty("financial_account_transactions")]
        public AccountSessionComponentsFinancialAccountTransactionsOptions FinancialAccountTransactions { get; set; }

        /// <summary>
        /// Configuration for the issuing card component.
        /// </summary>
        [JsonProperty("issuing_card")]
        public AccountSessionComponentsIssuingCardOptions IssuingCard { get; set; }

        /// <summary>
        /// Configuration for the issuing cards list component.
        /// </summary>
        [JsonProperty("issuing_cards_list")]
        public AccountSessionComponentsIssuingCardsListOptions IssuingCardsList { get; set; }

        /// <summary>
        /// Configuration for the notification banner embedded component.
        /// </summary>
        [JsonProperty("notification_banner")]
        public AccountSessionComponentsNotificationBannerOptions NotificationBanner { get; set; }

        /// <summary>
        /// Configuration for the payment details embedded component.
        /// </summary>
        [JsonProperty("payment_details")]
        public AccountSessionComponentsPaymentDetailsOptions PaymentDetails { get; set; }

        /// <summary>
        /// Configuration for the payments embedded component.
        /// </summary>
        [JsonProperty("payments")]
        public AccountSessionComponentsPaymentsOptions Payments { get; set; }

        /// <summary>
        /// Configuration for the payouts embedded component.
        /// </summary>
        [JsonProperty("payouts")]
        public AccountSessionComponentsPayoutsOptions Payouts { get; set; }

        /// <summary>
        /// Configuration for the payouts list embedded component.
        /// </summary>
        [JsonProperty("payouts_list")]
        public AccountSessionComponentsPayoutsListOptions PayoutsList { get; set; }

        /// <summary>
        /// Configuration for the tax registrations embedded component.
        /// </summary>
        [JsonProperty("tax_registrations")]
        public AccountSessionComponentsTaxRegistrationsOptions TaxRegistrations { get; set; }

        /// <summary>
        /// Configuration for the tax settings embedded component.
        /// </summary>
        [JsonProperty("tax_settings")]
        public AccountSessionComponentsTaxSettingsOptions TaxSettings { get; set; }
    }
}
