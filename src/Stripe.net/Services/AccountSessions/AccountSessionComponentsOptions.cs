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
        /// href="https://stripe.com/connect/supported-embedded-components/financial-reports#balance-report">balance
        /// report</a> embedded component.
        /// </summary>
        [JsonProperty("balance_report")]
        [STJS.JsonPropertyName("balance_report")]
        public AccountSessionComponentsBalanceReportOptions BalanceReport { get; set; }

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
        /// href="https://stripe.com/connect/supported-embedded-components/financial-reports#payout-reconciliation-report">payout
        /// reconciliation report</a> embedded component.
        /// </summary>
        [JsonProperty("payout_reconciliation_report")]
        [STJS.JsonPropertyName("payout_reconciliation_report")]
        public AccountSessionComponentsPayoutReconciliationReportOptions PayoutReconciliationReport { get; set; }

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
    }
}
