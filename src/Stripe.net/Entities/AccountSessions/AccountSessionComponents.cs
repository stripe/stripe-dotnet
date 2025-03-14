// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSessionComponents : StripeEntity<AccountSessionComponents>
    {
        [JsonProperty("account_management")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_management")]
#endif
        public AccountSessionComponentsAccountManagement AccountManagement { get; set; }

        [JsonProperty("account_onboarding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_onboarding")]
#endif
        public AccountSessionComponentsAccountOnboarding AccountOnboarding { get; set; }

        [JsonProperty("balances")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balances")]
#endif
        public AccountSessionComponentsBalances Balances { get; set; }

        [JsonProperty("capital_financing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capital_financing")]
#endif
        public AccountSessionComponentsCapitalFinancing CapitalFinancing { get; set; }

        [JsonProperty("capital_financing_application")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capital_financing_application")]
#endif
        public AccountSessionComponentsCapitalFinancingApplication CapitalFinancingApplication { get; set; }

        [JsonProperty("capital_financing_promotion")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capital_financing_promotion")]
#endif
        public AccountSessionComponentsCapitalFinancingPromotion CapitalFinancingPromotion { get; set; }

        [JsonProperty("documents")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("documents")]
#endif
        public AccountSessionComponentsDocuments Documents { get; set; }

        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public AccountSessionComponentsFinancialAccount FinancialAccount { get; set; }

        [JsonProperty("financial_account_transactions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account_transactions")]
#endif
        public AccountSessionComponentsFinancialAccountTransactions FinancialAccountTransactions { get; set; }

        [JsonProperty("issuing_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuing_card")]
#endif
        public AccountSessionComponentsIssuingCard IssuingCard { get; set; }

        [JsonProperty("issuing_cards_list")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuing_cards_list")]
#endif
        public AccountSessionComponentsIssuingCardsList IssuingCardsList { get; set; }

        [JsonProperty("notification_banner")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("notification_banner")]
#endif
        public AccountSessionComponentsNotificationBanner NotificationBanner { get; set; }

        [JsonProperty("payment_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_details")]
#endif
        public AccountSessionComponentsPaymentDetails PaymentDetails { get; set; }

        [JsonProperty("payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payments")]
#endif
        public AccountSessionComponentsPayments Payments { get; set; }

        [JsonProperty("payouts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payouts")]
#endif
        public AccountSessionComponentsPayouts Payouts { get; set; }

        [JsonProperty("payouts_list")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payouts_list")]
#endif
        public AccountSessionComponentsPayoutsList PayoutsList { get; set; }

        [JsonProperty("tax_registrations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_registrations")]
#endif
        public AccountSessionComponentsTaxRegistrations TaxRegistrations { get; set; }

        [JsonProperty("tax_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_settings")]
#endif
        public AccountSessionComponentsTaxSettings TaxSettings { get; set; }
    }
}
