// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Options for customizing account balances and payout settings for a Stripe platform’s
    /// connected accounts.
    ///
    /// This API is only available for users enrolled in the public preview for Accounts v2 on
    /// Stripe Connect. If you are not in this preview, please use the <a
    /// href="https://docs.stripe.com/api/accounts?api-version=2025-03-31.basil">Accounts v1
    /// API</a> to manage your connected accounts’ balance settings instead.
    /// </summary>
    public class BalanceSettings : StripeEntity<BalanceSettings>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// A Boolean indicating if Stripe should try to reclaim negative balances from an attached
        /// bank account. See <a href="https://stripe.com/connect/account-balances">Understanding
        /// Connect account balances</a> for details. The default value is <c>false</c> when <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
        /// is <c>application</c>, which includes Custom accounts, otherwise <c>true</c>.
        /// </summary>
        [JsonProperty("debit_negative_balances")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("debit_negative_balances")]
#endif
        public bool? DebitNegativeBalances { get; set; }

        /// <summary>
        /// Settings specific to the account's payouts.
        /// </summary>
        [JsonProperty("payouts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payouts")]
#endif
        public BalanceSettingsPayouts Payouts { get; set; }

        [JsonProperty("settlement_timing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("settlement_timing")]
#endif
        public BalanceSettingsSettlementTiming SettlementTiming { get; set; }
    }
}
