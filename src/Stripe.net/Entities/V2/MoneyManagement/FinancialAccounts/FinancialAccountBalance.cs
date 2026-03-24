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
        /// Balance that can be used for money movement.
        /// </summary>
        [JsonProperty("available")]
        [STJS.JsonPropertyName("available")]
        public Dictionary<string, V2.Amount> Available { get; set; }

        /// <summary>
        /// Balance of inbound funds that will later transition to the <c>available</c> balance.
        /// </summary>
        [JsonProperty("inbound_pending")]
        [STJS.JsonPropertyName("inbound_pending")]
        public Dictionary<string, V2.Amount> InboundPending { get; set; }

        /// <summary>
        /// Balance of funds that are being used for a pending outbound money movement.
        /// </summary>
        [JsonProperty("outbound_pending")]
        [STJS.JsonPropertyName("outbound_pending")]
        public Dictionary<string, V2.Amount> OutboundPending { get; set; }
    }
}
