// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2CoreAccountIncludingConfigurationCardCreatorCapabilityStatusUpdatedEventData : StripeEntity<V2CoreAccountIncludingConfigurationCardCreatorCapabilityStatusUpdatedEventData>
    {
        /// <summary>
        /// Open Enum. The capability which had its status updated.
        /// One of: <c>commercial.celtic.charge_card</c>, <c>commercial.celtic.spend_card</c>,
        /// <c>commercial.cross_river_bank.charge_card</c>,
        /// <c>commercial.cross_river_bank.spend_card</c>, <c>commercial.stripe.charge_card</c>, or
        /// <c>commercial.stripe.prepaid_card</c>.
        /// </summary>
        [JsonProperty("updated_capability")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("updated_capability")]
#endif
        public string UpdatedCapability { get; set; }
    }
}
