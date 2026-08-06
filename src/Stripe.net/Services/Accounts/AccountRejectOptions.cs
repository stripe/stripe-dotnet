// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountRejectOptions : BaseOptions
    {
        /// <summary>
        /// Whether to pause payouts on the account as part of the rejection. Defaults to
        /// <c>pause</c>. Use <c>none</c> to leave payouts enabled.
        /// One of: <c>none</c>, or <c>pause</c>.
        /// </summary>
        [JsonProperty("payouts_action")]
        [STJS.JsonPropertyName("payouts_action")]
        public string PayoutsAction { get; set; }

        /// <summary>
        /// The reason for rejecting the account. Can be <c>fraud</c>, <c>terms_of_service</c>, or
        /// <c>other</c>.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
