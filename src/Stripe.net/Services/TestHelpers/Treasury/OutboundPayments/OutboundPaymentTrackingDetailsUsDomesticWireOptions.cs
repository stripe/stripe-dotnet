// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;

    public class OutboundPaymentTrackingDetailsUsDomesticWireOptions : INestedOptions
    {
        /// <summary>
        /// IMAD for funds sent over the <c>us_domestic_wire</c> network.
        /// </summary>
        [JsonProperty("imad")]
        public string Imad { get; set; }

        /// <summary>
        /// OMAD for funds sent over the <c>us_domestic_wire</c> network.
        /// </summary>
        [JsonProperty("omad")]
        public string Omad { get; set; }
    }
}
