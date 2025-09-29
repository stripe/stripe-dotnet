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
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/account-management/">account
        /// management</a> embedded component.
        /// </summary>
        [JsonProperty("account_management")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_management")]
#endif
        public AccountSessionComponentsAccountManagementOptions AccountManagement { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/account-onboarding/">account
        /// onboarding</a> embedded component.
        /// </summary>
        [JsonProperty("account_onboarding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_onboarding")]
#endif
        public AccountSessionComponentsAccountOnboardingOptions AccountOnboarding { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/balances/">balances</a>
        /// embedded component.
        /// </summary>
        [JsonProperty("balances")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balances")]
#endif
        public AccountSessionComponentsBalancesOptions Balances { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/disputes-list/">disputes
        /// list</a> embedded component.
        /// </summary>
        [JsonProperty("disputes_list")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("disputes_list")]
#endif
        public AccountSessionComponentsDisputesListOptions DisputesList { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/documents/">documents</a>
        /// embedded component.
        /// </summary>
        [JsonProperty("documents")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("documents")]
#endif
        public AccountSessionComponentsDocumentsOptions Documents { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/financial-account/">financial
        /// account</a> embedded component.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public AccountSessionComponentsFinancialAccountOptions FinancialAccount { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/financial-account-transactions/">financial
        /// account transactions</a> embedded component.
        /// </summary>
        [JsonProperty("financial_account_transactions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account_transactions")]
#endif
        public AccountSessionComponentsFinancialAccountTransactionsOptions FinancialAccountTransactions { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/instant-payouts-promotion/">instant
        /// payouts promotion</a> embedded component.
        /// </summary>
        [JsonProperty("instant_payouts_promotion")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("instant_payouts_promotion")]
#endif
        public AccountSessionComponentsInstantPayoutsPromotionOptions InstantPayoutsPromotion { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/issuing-card/">issuing
        /// card</a> embedded component.
        /// </summary>
        [JsonProperty("issuing_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuing_card")]
#endif
        public AccountSessionComponentsIssuingCardOptions IssuingCard { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/issuing-cards-list/">issuing
        /// cards list</a> embedded component.
        /// </summary>
        [JsonProperty("issuing_cards_list")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuing_cards_list")]
#endif
        public AccountSessionComponentsIssuingCardsListOptions IssuingCardsList { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/notification-banner/">notification
        /// banner</a> embedded component.
        /// </summary>
        [JsonProperty("notification_banner")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("notification_banner")]
#endif
        public AccountSessionComponentsNotificationBannerOptions NotificationBanner { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/payment-details/">payment
        /// details</a> embedded component.
        /// </summary>
        [JsonProperty("payment_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_details")]
#endif
        public AccountSessionComponentsPaymentDetailsOptions PaymentDetails { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/payment-disputes/">payment
        /// disputes</a> embedded component.
        /// </summary>
        [JsonProperty("payment_disputes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_disputes")]
#endif
        public AccountSessionComponentsPaymentDisputesOptions PaymentDisputes { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/payments/">payments</a>
        /// embedded component.
        /// </summary>
        [JsonProperty("payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payments")]
#endif
        public AccountSessionComponentsPaymentsOptions Payments { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/payout-details/">payout
        /// details</a> embedded component.
        /// </summary>
        [JsonProperty("payout_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payout_details")]
#endif
        public AccountSessionComponentsPayoutDetailsOptions PayoutDetails { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/payouts/">payouts</a>
        /// embedded component.
        /// </summary>
        [JsonProperty("payouts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payouts")]
#endif
        public AccountSessionComponentsPayoutsOptions Payouts { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/payouts-list/">payouts
        /// list</a> embedded component.
        /// </summary>
        [JsonProperty("payouts_list")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payouts_list")]
#endif
        public AccountSessionComponentsPayoutsListOptions PayoutsList { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/tax-registrations/">tax
        /// registrations</a> embedded component.
        /// </summary>
        [JsonProperty("tax_registrations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_registrations")]
#endif
        public AccountSessionComponentsTaxRegistrationsOptions TaxRegistrations { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/tax-settings/">tax
        /// settings</a> embedded component.
        /// </summary>
        [JsonProperty("tax_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_settings")]
#endif
        public AccountSessionComponentsTaxSettingsOptions TaxSettings { get; set; }
    }
}
