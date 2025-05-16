// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BalanceRefundAndDisputePrefunding : StripeEntity<BalanceRefundAndDisputePrefunding>
    {
        /// <summary>
        /// Funds that are available for use.
        /// </summary>
        [JsonProperty("available")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("available")]
#endif
        public List<BalanceRefundAndDisputePrefundingAvailable> Available { get; set; }

        /// <summary>
        /// Funds that are pending.
        /// </summary>
        [JsonProperty("pending")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pending")]
#endif
        public List<BalanceRefundAndDisputePrefundingPending> Pending { get; set; }
    }
}
