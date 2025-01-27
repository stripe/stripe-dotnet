// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

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
        public bool DisableStripeUserAuthentication { get; set; }

        /// <summary>
        /// Whether to allow external accounts to be linked for money transfer.
        /// </summary>
        [JsonProperty("external_account_collection")]
        public bool ExternalAccountCollection { get; set; }

        /// <summary>
        /// Whether to allow sending money.
        /// </summary>
        [JsonProperty("send_money")]
        public bool SendMoney { get; set; }

        /// <summary>
        /// Whether to allow transferring balance.
        /// </summary>
        [JsonProperty("transfer_balance")]
        public bool TransferBalance { get; set; }
    }
}
