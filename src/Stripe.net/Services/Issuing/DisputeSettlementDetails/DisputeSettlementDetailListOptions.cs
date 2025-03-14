// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputeSettlementDetailListOptions : ListOptions
    {
        /// <summary>
        /// Select the Issuing dispute settlement details for the given settlement.
        /// </summary>
        [JsonProperty("settlement")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("settlement")]
#endif
        public string Settlement { get; set; }
    }
}
