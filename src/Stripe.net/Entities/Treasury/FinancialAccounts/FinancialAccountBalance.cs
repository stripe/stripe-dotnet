// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountBalance : StripeEntity<FinancialAccountBalance>
    {
        /// <summary>
        /// Funds the user can spend right now.
        /// </summary>
        [JsonProperty("cash")]
        [STJS.JsonPropertyName("cash")]
        public Dictionary<string, long> Cash { get; set; }

        /// <summary>
        /// Funds not spendable yet, but will become available at a later time.
        /// </summary>
        [JsonProperty("inbound_pending")]
        [STJS.JsonPropertyName("inbound_pending")]
        public Dictionary<string, long> InboundPending { get; set; }

        /// <summary>
        /// Funds in the account, but not spendable because they are being held for pending outbound
        /// flows.
        /// </summary>
        [JsonProperty("outbound_pending")]
        [STJS.JsonPropertyName("outbound_pending")]
        public Dictionary<string, long> OutboundPending { get; set; }
    }
}
