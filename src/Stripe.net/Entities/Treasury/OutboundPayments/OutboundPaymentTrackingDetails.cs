// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentTrackingDetails : StripeEntity<OutboundPaymentTrackingDetails>
    {
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public OutboundPaymentTrackingDetailsAch Ach { get; set; }

        /// <summary>
        /// The US bank account network used to send funds.
        /// One of: <c>ach</c>, or <c>us_domestic_wire</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("us_domestic_wire")]
        [STJS.JsonPropertyName("us_domestic_wire")]
        public OutboundPaymentTrackingDetailsUsDomesticWire UsDomesticWire { get; set; }
    }
}
