// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventData : StripeEntity<V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventData>
    {
        /// <summary>
        /// Open Enum. The capability which had its status updated.
        /// One of: <c>bank_accounts.instant</c>, <c>bank_accounts.local</c>,
        /// <c>bank_accounts.wire</c>, <c>cards</c>, <c>crypto_wallets_v2</c>, <c>paper_checks</c>,
        /// <c>stripe_balance.payouts</c>, <c>stripe_balance.stripe_transfers</c>, or
        /// <c>stripe.transfers</c>.
        /// </summary>
        [JsonProperty("updated_capability")]
        [STJS.JsonPropertyName("updated_capability")]
        public string UpdatedCapability { get; set; }
    }
}
