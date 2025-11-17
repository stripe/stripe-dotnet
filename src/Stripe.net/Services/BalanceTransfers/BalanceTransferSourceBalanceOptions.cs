// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BalanceTransferSourceBalanceOptions : INestedOptions
    {
        [JsonProperty("allocated_funds")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allocated_funds")]
#endif
        public BalanceTransferSourceBalanceAllocatedFundsOptions AllocatedFunds { get; set; }

        /// <summary>
        /// Source balance type to pull funds from for the Balance Transfer.
        /// One of: <c>allocated_funds</c>, <c>issuing</c>, or <c>payments</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
