// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventData : StripeEntity<V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventData>
    {
        /// <summary>
        /// Open Enum. The capability which had its status updated.
        /// One of: <c>bank_accounts.local</c>, <c>bank_accounts.local_uk</c>,
        /// <c>bank_accounts.wire</c>, <c>bank_accounts.wire_uk</c>, <c>cards</c>, <c>cards_uk</c>,
        /// <c>crypto_wallets_v2</c>, <c>stripe_balance.stripe_transfers</c>, or
        /// <c>stripe.transfers</c>.
        /// </summary>
        [JsonProperty("updated_capability")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("updated_capability")]
#endif
        public string UpdatedCapability { get; set; }
    }
}
