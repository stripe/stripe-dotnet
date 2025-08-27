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

        [JsonProperty("payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payments")]
#endif
        public BalanceSettingsPayments Payments { get; set; }
    }
}
