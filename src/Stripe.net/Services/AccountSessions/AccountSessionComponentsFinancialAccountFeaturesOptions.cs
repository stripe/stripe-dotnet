// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionComponentsFinancialAccountFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// Disables Stripe user authentication for this embedded component. This feature can only
        /// be false for accounts where you’re responsible for collecting updated information when
        /// requirements are due or change, like custom accounts. The default value for this feature
        /// is <c>false</c> when <c>external_account_collection</c> is enabled and <c>true</c>
        /// otherwise.
        /// </summary>
        [JsonProperty("disable_stripe_user_authentication")]
        public bool? DisableStripeUserAuthentication { get; set; }

        /// <summary>
        /// Whether to allow external accounts to be linked for money transfer.
        /// </summary>
        [JsonProperty("external_account_collection")]
        public bool? ExternalAccountCollection { get; set; }

        /// <summary>
        /// Whether to allow sending money.
        /// </summary>
        [JsonProperty("send_money")]
        public bool? SendMoney { get; set; }

        /// <summary>
        /// Whether to allow transferring balance.
        /// </summary>
        [JsonProperty("transfer_balance")]
        public bool? TransferBalance { get; set; }
    }
}
