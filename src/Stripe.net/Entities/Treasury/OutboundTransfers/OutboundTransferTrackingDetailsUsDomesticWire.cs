// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundTransferTrackingDetailsUsDomesticWire : StripeEntity<OutboundTransferTrackingDetailsUsDomesticWire>
    {
        /// <summary>
        /// CHIPS System Sequence Number (SSN) of the OutboundTransfer for transfers sent over the
        /// <c>us_domestic_wire</c> network.
        /// </summary>
        [JsonProperty("chips")]
        [STJS.JsonPropertyName("chips")]
        public string Chips { get; set; }

        /// <summary>
        /// IMAD of the OutboundTransfer for transfers sent over the <c>us_domestic_wire</c>
        /// network.
        /// </summary>
        [JsonProperty("imad")]
        [STJS.JsonPropertyName("imad")]
        public string Imad { get; set; }

        /// <summary>
        /// OMAD of the OutboundTransfer for transfers sent over the <c>us_domestic_wire</c>
        /// network.
        /// </summary>
        [JsonProperty("omad")]
        [STJS.JsonPropertyName("omad")]
        public string Omad { get; set; }
    }
}
