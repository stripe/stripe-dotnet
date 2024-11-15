// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundTransferTrackingDetailsOptions : INestedOptions
    {
        /// <summary>
        /// ACH network tracking details.
        /// </summary>
        [JsonProperty("ach")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ach")]
#endif

        public OutboundTransferTrackingDetailsAchOptions Ach { get; set; }

        /// <summary>
        /// The US bank account network used to send funds.
        /// One of: <c>ach</c>, or <c>us_domestic_wire</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }

        /// <summary>
        /// US domestic wire network tracking details.
        /// </summary>
        [JsonProperty("us_domestic_wire")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_domestic_wire")]
#endif

        public OutboundTransferTrackingDetailsUsDomesticWireOptions UsDomesticWire { get; set; }
    }
}
