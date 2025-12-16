// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SettlementAllocationIntentStatusDetails : StripeEntity<SettlementAllocationIntentStatusDetails>
    {
        /// <summary>
        /// Hash that provides additional information regarding the reason behind a <c>errored</c>
        /// SettlementAllocationIntent status. It is only present when the
        /// SettlementAllocationIntent status is <c>errored</c>.
        /// </summary>
        [JsonProperty("errored")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("errored")]
#endif
        public SettlementAllocationIntentStatusDetailsErrored Errored { get; set; }
    }
}
