// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundTransferTrackingDetailsUsDomesticWireOptions : INestedOptions
    {
        /// <summary>
        /// CHIPS System Sequence Number (SSN) for funds sent over the <c>us_domestic_wire</c>
        /// network.
        /// </summary>
        [JsonProperty("chips")]
        [STJS.JsonPropertyName("chips")]
        public string Chips { get; set; }

        /// <summary>
        /// IMAD for funds sent over the <c>us_domestic_wire</c> network.
        /// </summary>
        [JsonProperty("imad")]
        [STJS.JsonPropertyName("imad")]
        public string Imad { get; set; }

        /// <summary>
        /// OMAD for funds sent over the <c>us_domestic_wire</c> network.
        /// </summary>
        [JsonProperty("omad")]
        [STJS.JsonPropertyName("omad")]
        public string Omad { get; set; }
    }
}
