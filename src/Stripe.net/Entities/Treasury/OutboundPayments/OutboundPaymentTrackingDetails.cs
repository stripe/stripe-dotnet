// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class OutboundPaymentTrackingDetails : StripeEntity<OutboundPaymentTrackingDetails>
    {
        [JsonProperty("ach")]
        public OutboundPaymentTrackingDetailsAch Ach { get; set; }

        /// <summary>
        /// The US bank account network used to send funds.
        /// One of: <c>ach</c>, or <c>us_domestic_wire</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("us_domestic_wire")]
        public OutboundPaymentTrackingDetailsUsDomesticWire UsDomesticWire { get; set; }
    }
}
