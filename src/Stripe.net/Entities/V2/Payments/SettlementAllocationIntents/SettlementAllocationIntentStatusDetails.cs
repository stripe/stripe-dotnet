// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SettlementAllocationIntentStatusDetails : StripeEntity<SettlementAllocationIntentStatusDetails>
    {
        /// <summary>
        /// Hash that provides additional information regarding the reason behind a <c>errored</c>
        /// SettlementAllocationIntent status. It is only present when the
        /// SettlementAllocationIntent status is <c>errored</c>.
        /// </summary>
        [JsonProperty("errored")]
        [STJS.JsonPropertyName("errored")]
        public SettlementAllocationIntentStatusDetailsErrored Errored { get; set; }
    }
}
