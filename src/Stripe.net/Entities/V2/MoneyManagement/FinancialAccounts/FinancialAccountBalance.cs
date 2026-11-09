// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountBalance : StripeEntity<FinancialAccountBalance>
    {
        /// <summary>
        /// Balance available for money movement.
        /// </summary>
        [JsonProperty("available")]
        [STJS.JsonPropertyName("available")]
        public Dictionary<string, V2.Amount> Available { get; set; }

        /// <summary>
        /// Balance of inbound funds that aren't yet available for money movement and will later
        /// move to the <c>available</c> balance.
        /// </summary>
        [JsonProperty("inbound_pending")]
        [STJS.JsonPropertyName("inbound_pending")]
        public Dictionary<string, V2.Amount> InboundPending { get; set; }

        /// <summary>
        /// Balance of funds being used for pending outbound money movements.
        /// </summary>
        [JsonProperty("outbound_pending")]
        [STJS.JsonPropertyName("outbound_pending")]
        public Dictionary<string, V2.Amount> OutboundPending { get; set; }
    }
}
