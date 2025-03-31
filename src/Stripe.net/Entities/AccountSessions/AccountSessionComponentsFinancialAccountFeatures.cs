// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSessionComponentsFinancialAccountFeatures : StripeEntity<AccountSessionComponentsFinancialAccountFeatures>
    {
        /// <summary>
        /// Disables Stripe user authentication for this embedded component. This value can only be
        /// true for accounts where <c>controller.requirement_collection</c> is <c>application</c>.
        /// The default value is the opposite of the <c>external_account_collection</c> value. For
        /// example, if you don’t set <c>external_account_collection</c>, it defaults to true and
        /// <c>disable_stripe_user_authentication</c> defaults to false.
        /// </summary>
        [JsonProperty("disable_stripe_user_authentication")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("disable_stripe_user_authentication")]
#endif
        public bool DisableStripeUserAuthentication { get; set; }

        /// <summary>
        /// Whether to allow external accounts to be linked for money transfer.
        /// </summary>
        [JsonProperty("external_account_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("external_account_collection")]
#endif
        public bool ExternalAccountCollection { get; set; }

        /// <summary>
        /// Whether to allow sending money.
        /// </summary>
        [JsonProperty("send_money")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("send_money")]
#endif
        public bool SendMoney { get; set; }

        /// <summary>
        /// Whether to allow transferring balance.
        /// </summary>
        [JsonProperty("transfer_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_balance")]
#endif
        public bool TransferBalance { get; set; }
    }
}
