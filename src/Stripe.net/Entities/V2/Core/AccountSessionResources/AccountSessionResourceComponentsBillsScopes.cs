// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSessionResourceComponentsBillsScopes : StripeEntity<AccountSessionResourceComponentsBillsScopes>
    {
        /// <summary>
        /// Whether to allow creating outbound payments.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("create_outbound_payments")]
        [STJS.JsonPropertyName("create_outbound_payments")]
        public string CreateOutboundPayments { get; set; }

        /// <summary>
        /// Whether to disable Stripe user authentication in the enabled components.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("disable_stripe_user_authentication")]
        [STJS.JsonPropertyName("disable_stripe_user_authentication")]
        public string DisableStripeUserAuthentication { get; set; }

        /// <summary>
        /// Whether to allow managing bills.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("manage_bills")]
        [STJS.JsonPropertyName("manage_bills")]
        public string ManageBills { get; set; }
    }
}
