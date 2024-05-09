// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;

    public class OutboundTransferTrackingDetailsOptions : INestedOptions
    {
        /// <summary>
        /// ACH network tracking details.
        /// </summary>
        [JsonProperty("ach")]
        public OutboundTransferTrackingDetailsAchOptions Ach { get; set; }

        /// <summary>
        /// The US bank account network used to send funds.
        /// One of: <c>ach</c>, or <c>us_domestic_wire</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// US domestic wire network tracking details.
        /// </summary>
        [JsonProperty("us_domestic_wire")]
        public OutboundTransferTrackingDetailsUsDomesticWireOptions UsDomesticWire { get; set; }
    }
}
