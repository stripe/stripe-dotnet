// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSessionComponents : StripeEntity<AccountSessionComponents>
    {
        [JsonProperty("account_management")]
        [STJS.JsonPropertyName("account_management")]
        public AccountSessionComponentsAccountManagement AccountManagement { get; set; }

        [JsonProperty("account_onboarding")]
        [STJS.JsonPropertyName("account_onboarding")]
        public AccountSessionComponentsAccountOnboarding AccountOnboarding { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/agentic-commerce-settings/">agentic
        /// commerce settings</a> embedded component.
        /// </summary>
        [JsonProperty("agentic_commerce_settings")]
        [STJS.JsonPropertyName("agentic_commerce_settings")]
        public AccountSessionComponentsAgenticCommerceSettings AgenticCommerceSettings { get; set; }

        [JsonProperty("balances")]
        [STJS.JsonPropertyName("balances")]
        public AccountSessionComponentsBalances Balances { get; set; }

        [JsonProperty("capital_financing")]
        [STJS.JsonPropertyName("capital_financing")]
        public AccountSessionComponentsCapitalFinancing CapitalFinancing { get; set; }

        [JsonProperty("capital_financing_application")]
        [STJS.JsonPropertyName("capital_financing_application")]
        public AccountSessionComponentsCapitalFinancingApplication CapitalFinancingApplication { get; set; }

        [JsonProperty("capital_financing_promotion")]
        [STJS.JsonPropertyName("capital_financing_promotion")]
        public AccountSessionComponentsCapitalFinancingPromotion CapitalFinancingPromotion { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/check-scanning/">check
        /// scanning</a> embedded component.
        /// </summary>
        [JsonProperty("check_scanning")]
        [STJS.JsonPropertyName("check_scanning")]
        public AccountSessionComponentsCheckScanning CheckScanning { get; set; }

        [JsonProperty("disputes_list")]
        [STJS.JsonPropertyName("disputes_list")]
        public AccountSessionComponentsDisputesList DisputesList { get; set; }

        [JsonProperty("documents")]
        [STJS.JsonPropertyName("documents")]
        public AccountSessionComponentsDocuments Documents { get; set; }

        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public AccountSessionComponentsFinancialAccount FinancialAccount { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/financial-account-rewards/">financial
        /// account rewards</a> embedded component.
        /// </summary>
        [JsonProperty("financial_account_rewards")]
        [STJS.JsonPropertyName("financial_account_rewards")]
        public AccountSessionComponentsFinancialAccountRewards FinancialAccountRewards { get; set; }

        [JsonProperty("financial_account_transactions")]
        [STJS.JsonPropertyName("financial_account_transactions")]
        public AccountSessionComponentsFinancialAccountTransactions FinancialAccountTransactions { get; set; }

        [JsonProperty("instant_payouts_promotion")]
        [STJS.JsonPropertyName("instant_payouts_promotion")]
        public AccountSessionComponentsInstantPayoutsPromotion InstantPayoutsPromotion { get; set; }

        [JsonProperty("issuing_card")]
        [STJS.JsonPropertyName("issuing_card")]
        public AccountSessionComponentsIssuingCard IssuingCard { get; set; }

        [JsonProperty("issuing_cards_list")]
        [STJS.JsonPropertyName("issuing_cards_list")]
        public AccountSessionComponentsIssuingCardsList IssuingCardsList { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/nesting-demo/">Nestingdemo</a>
        /// embedded component.
        /// </summary>
        [JsonProperty("nesting_demo")]
        [STJS.JsonPropertyName("nesting_demo")]
        public AccountSessionComponentsNestingDemo NestingDemo { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/network-cost-passthrough-report/">network
        /// cost passthrough report</a> embedded component.
        /// </summary>
        [JsonProperty("network_cost_passthrough_report")]
        [STJS.JsonPropertyName("network_cost_passthrough_report")]
        public AccountSessionComponentsNetworkCostPassthroughReport NetworkCostPassthroughReport { get; set; }

        [JsonProperty("notification_banner")]
        [STJS.JsonPropertyName("notification_banner")]
        public AccountSessionComponentsNotificationBanner NotificationBanner { get; set; }

        [JsonProperty("payment_details")]
        [STJS.JsonPropertyName("payment_details")]
        public AccountSessionComponentsPaymentDetails PaymentDetails { get; set; }

        [JsonProperty("payment_disputes")]
        [STJS.JsonPropertyName("payment_disputes")]
        public AccountSessionComponentsPaymentDisputes PaymentDisputes { get; set; }

        [JsonProperty("payments")]
        [STJS.JsonPropertyName("payments")]
        public AccountSessionComponentsPayments Payments { get; set; }

        [JsonProperty("payout_details")]
        [STJS.JsonPropertyName("payout_details")]
        public AccountSessionComponentsPayoutDetails PayoutDetails { get; set; }

        [JsonProperty("payouts")]
        [STJS.JsonPropertyName("payouts")]
        public AccountSessionComponentsPayouts Payouts { get; set; }

        [JsonProperty("payouts_list")]
        [STJS.JsonPropertyName("payouts_list")]
        public AccountSessionComponentsPayoutsList PayoutsList { get; set; }

        [JsonProperty("tax_registrations")]
        [STJS.JsonPropertyName("tax_registrations")]
        public AccountSessionComponentsTaxRegistrations TaxRegistrations { get; set; }

        [JsonProperty("tax_settings")]
        [STJS.JsonPropertyName("tax_settings")]
        public AccountSessionComponentsTaxSettings TaxSettings { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/terminal-hardware-orders/">Terminal
        /// hardware orders</a> embedded component.
        /// </summary>
        [JsonProperty("terminal_hardware_orders")]
        [STJS.JsonPropertyName("terminal_hardware_orders")]
        public AccountSessionComponentsTerminalHardwareOrders TerminalHardwareOrders { get; set; }

        /// <summary>
        /// Configuration for the <a
        /// href="https://stripe.com/connect/supported-embedded-components/terminal-hardware-shop/">Terminal
        /// hardware shop</a> embedded component.
        /// </summary>
        [JsonProperty("terminal_hardware_shop")]
        [STJS.JsonPropertyName("terminal_hardware_shop")]
        public AccountSessionComponentsTerminalHardwareShop TerminalHardwareShop { get; set; }
    }
}
