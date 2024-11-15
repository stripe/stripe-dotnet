// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentTrackingDetailsUsDomesticWire : StripeEntity<OutboundPaymentTrackingDetailsUsDomesticWire>
    {
        /// <summary>
        /// CHIPS System Sequence Number (SSN) of the OutboundPayment for payments sent over the
        /// <c>us_domestic_wire</c> network.
        /// </summary>
        [JsonProperty("chips")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("chips")]
#endif

        public string Chips { get; set; }

        /// <summary>
        /// IMAD of the OutboundPayment for payments sent over the <c>us_domestic_wire</c> network.
        /// </summary>
        [JsonProperty("imad")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("imad")]
#endif

        public string Imad { get; set; }

        /// <summary>
        /// OMAD of the OutboundPayment for payments sent over the <c>us_domestic_wire</c> network.
        /// </summary>
        [JsonProperty("omad")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("omad")]
#endif

        public string Omad { get; set; }
    }
}
