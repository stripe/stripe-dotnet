// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BalanceTransferSourceBalance : StripeEntity<BalanceTransferSourceBalance>
    {
        [JsonProperty("issuing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuing")]
#endif
        public BalanceTransferSourceBalanceIssuing Issuing { get; set; }

        [JsonProperty("payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payments")]
#endif
        public BalanceTransferSourceBalancePayments Payments { get; set; }

        /// <summary>
        /// Source balance type to adjust for the Balance Transfer. One of <c>payments</c>,
        /// <c>issuing</c>, or <c>allocated_funds</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
