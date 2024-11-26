// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundTransferTrackingDetails : StripeEntity<OutboundTransferTrackingDetails>
    {
        [JsonProperty("ach")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ach")]
#endif
        public OutboundTransferTrackingDetailsAch Ach { get; set; }

        /// <summary>
        /// The US bank account network used to send funds.
        /// One of: <c>ach</c>, or <c>us_domestic_wire</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        [JsonProperty("us_domestic_wire")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_domestic_wire")]
#endif
        public OutboundTransferTrackingDetailsUsDomesticWire UsDomesticWire { get; set; }
    }
}
