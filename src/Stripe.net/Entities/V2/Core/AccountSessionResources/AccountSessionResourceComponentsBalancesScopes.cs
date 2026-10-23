// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSessionResourceComponentsBalancesScopes : StripeEntity<AccountSessionResourceComponentsBalancesScopes>
    {
        /// <summary>
        /// Controls whether creating instant payouts is enabled, disabled, or determined by
        /// Dashboard rules.
        /// One of: <c>disabled</c>, <c>enabled</c>, or <c>use_dashboard_rules</c>.
        /// </summary>
        [JsonProperty("create_instant_payouts")]
        [STJS.JsonPropertyName("create_instant_payouts")]
        public string CreateInstantPayouts { get; set; }

        /// <summary>
        /// Whether to allow changing the payout schedule.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("create_payout_schedule")]
        [STJS.JsonPropertyName("create_payout_schedule")]
        public string CreatePayoutSchedule { get; set; }

        /// <summary>
        /// Whether to allow creating standard payouts.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("create_standard_payouts")]
        [STJS.JsonPropertyName("create_standard_payouts")]
        public string CreateStandardPayouts { get; set; }

        /// <summary>
        /// Whether to disable Stripe user authentication in the enabled components.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("disable_stripe_user_authentication")]
        [STJS.JsonPropertyName("disable_stripe_user_authentication")]
        public string DisableStripeUserAuthentication { get; set; }

        /// <summary>
        /// Whether to allow managing payout methods.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("manage_payout_methods")]
        [STJS.JsonPropertyName("manage_payout_methods")]
        public string ManagePayoutMethods { get; set; }
    }
}
