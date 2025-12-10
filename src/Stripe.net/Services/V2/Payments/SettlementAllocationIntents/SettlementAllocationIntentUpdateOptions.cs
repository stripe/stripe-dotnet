// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SettlementAllocationIntentUpdateOptions : BaseOptions
    {
        /// <summary>
        /// The new amount for the SettlementAllocationIntent.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public SettlementAllocationIntentUpdateAmountOptions Amount { get; set; }

        /// <summary>
        /// The new reference for the SettlementAllocationIntent.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public string Reference { get; set; }
    }
}
