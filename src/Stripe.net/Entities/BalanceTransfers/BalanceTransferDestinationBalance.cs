// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BalanceTransferDestinationBalance : StripeEntity<BalanceTransferDestinationBalance>
    {
        [JsonProperty("issuing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuing")]
#endif
        public BalanceTransferDestinationBalanceIssuing Issuing { get; set; }

        [JsonProperty("payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payments")]
#endif
        public BalanceTransferDestinationBalancePayments Payments { get; set; }

        /// <summary>
        /// Destination balance type to adjust for the Balance Transfer. One of <c>payments</c>,
        /// <c>issuing</c>, or <c>allocated_funds</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
