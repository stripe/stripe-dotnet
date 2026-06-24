// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSessionComponentsFinancialAccountsFeatures : StripeEntity<AccountSessionComponentsFinancialAccountsFeatures>
    {
        /// <summary>
        /// Whether to allow bill management features.
        /// </summary>
        [JsonProperty("bill_management")]
        [STJS.JsonPropertyName("bill_management")]
        public bool BillManagement { get; set; }

        /// <summary>
        /// Whether to allow card management features.
        /// </summary>
        [JsonProperty("card_management")]
        [STJS.JsonPropertyName("card_management")]
        public bool CardManagement { get; set; }

        /// <summary>
        /// Whether Stripe user authentication is disabled. This value can only be <c>true</c> for
        /// accounts where <c>controller.requirement_collection</c> is <c>application</c> for the
        /// account. This is <c>false</c> by default.
        /// </summary>
        [JsonProperty("disable_stripe_user_authentication")]
        [STJS.JsonPropertyName("disable_stripe_user_authentication")]
        public bool DisableStripeUserAuthentication { get; set; }

        /// <summary>
        /// Whether to allow payout schedule to be changed. Defaults to <c>true</c> when
        /// <c>controller.losses.payments</c> is set to <c>stripe</c> for the account, otherwise
        /// <c>false</c>.
        /// </summary>
        [JsonProperty("edit_payout_schedule")]
        [STJS.JsonPropertyName("edit_payout_schedule")]
        public bool EditPayoutSchedule { get; set; }

        /// <summary>
        /// Whether to enable the send money feature that grants access to the v2
        /// CreateOutboundPayment API.
        /// </summary>
        [JsonProperty("send_money")]
        [STJS.JsonPropertyName("send_money")]
        public bool SendMoney { get; set; }
    }
}
