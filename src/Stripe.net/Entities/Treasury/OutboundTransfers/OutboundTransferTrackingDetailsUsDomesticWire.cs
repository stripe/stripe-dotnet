// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class OutboundTransferTrackingDetailsUsDomesticWire : StripeEntity<OutboundTransferTrackingDetailsUsDomesticWire>
    {
        /// <summary>
        /// IMAD of the OutboundTransfer for transfers sent over the <c>us_domestic_wire</c>
        /// network.
        /// </summary>
        [JsonProperty("imad")]
        public string Imad { get; set; }

        /// <summary>
        /// OMAD of the OutboundTransfer for transfers sent over the <c>us_domestic_wire</c>
        /// network.
        /// </summary>
        [JsonProperty("omad")]
        public string Omad { get; set; }
    }
}
