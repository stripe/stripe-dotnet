// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSessionComponentsFinancialAccountFeatures : StripeEntity<AccountSessionComponentsFinancialAccountFeatures>
    {
        /// <summary>
        /// Whether Stripe user authentication is disabled. This value can only be <c>true</c> for
        /// accounts where <c>controller.requirement_collection</c> is <c>application</c> for the
        /// account. The default value is the opposite of the <c>external_account_collection</c>
        /// value. For example, if you don't set <c>external_account_collection</c>, it defaults to
        /// <c>true</c> and <c>disable_stripe_user_authentication</c> defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("disable_stripe_user_authentication")]
        [STJS.JsonPropertyName("disable_stripe_user_authentication")]
        public bool DisableStripeUserAuthentication { get; set; }

        /// <summary>
        /// Whether external account collection is enabled. This feature can only be <c>false</c>
        /// for accounts where you’re responsible for collecting updated information when
        /// requirements are due or change, like Custom accounts. The default value for this feature
        /// is <c>true</c>.
        /// </summary>
        [JsonProperty("external_account_collection")]
        [STJS.JsonPropertyName("external_account_collection")]
        public bool ExternalAccountCollection { get; set; }

        /// <summary>
        /// Whether to allow sending money.
        /// </summary>
        [JsonProperty("send_money")]
        [STJS.JsonPropertyName("send_money")]
        public bool SendMoney { get; set; }

        /// <summary>
        /// Whether to allow transferring balance.
        /// </summary>
        [JsonProperty("transfer_balance")]
        [STJS.JsonPropertyName("transfer_balance")]
        public bool TransferBalance { get; set; }
    }
}
