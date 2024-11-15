// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountBalance : StripeEntity<FinancialAccountBalance>
    {
        /// <summary>
        /// Funds the user can spend right now.
        /// </summary>
        [JsonProperty("cash")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cash")]
#endif

        public Dictionary<string, long> Cash { get; set; }

        /// <summary>
        /// Funds not spendable yet, but will become available at a later time.
        /// </summary>
        [JsonProperty("inbound_pending")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("inbound_pending")]
#endif

        public Dictionary<string, long> InboundPending { get; set; }

        /// <summary>
        /// Funds in the account, but not spendable because they are being held for pending outbound
        /// flows.
        /// </summary>
        [JsonProperty("outbound_pending")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_pending")]
#endif

        public Dictionary<string, long> OutboundPending { get; set; }
    }
}
