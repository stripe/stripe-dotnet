// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountBalance : StripeEntity<FinancialAccountBalance>
    {
        /// <summary>
        /// Balance that can be used for money movement.
        /// </summary>
        [JsonProperty("available")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("available")]
#endif
        public Dictionary<string, V2.Amount> Available { get; set; }

        /// <summary>
        /// Balance of inbound funds that will later transition to the <c>cash</c> balance.
        /// </summary>
        [JsonProperty("inbound_pending")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("inbound_pending")]
#endif
        public Dictionary<string, V2.Amount> InboundPending { get; set; }

        /// <summary>
        /// Balance of funds that are being used for a pending outbound money movement.
        /// </summary>
        [JsonProperty("outbound_pending")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_pending")]
#endif
        public Dictionary<string, V2.Amount> OutboundPending { get; set; }
    }
}
