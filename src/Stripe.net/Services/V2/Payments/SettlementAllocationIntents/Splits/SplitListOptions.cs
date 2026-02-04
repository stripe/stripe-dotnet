// File generated from our OpenAPI spec
namespace Stripe.V2.Payments.SettlementAllocationIntents
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SplitListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter the SettlementAllocationIntentSplits by status.
        /// One of: <c>canceled</c>, <c>pending</c>, or <c>settled</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
