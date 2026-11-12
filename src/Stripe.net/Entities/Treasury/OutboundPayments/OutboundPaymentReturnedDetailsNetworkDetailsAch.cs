// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentReturnedDetailsNetworkDetailsAch : StripeEntity<OutboundPaymentReturnedDetailsNetworkDetailsAch>
    {
        /// <summary>
        /// NACHA ACH return code.
        /// </summary>
        [JsonProperty("return_code")]
        [STJS.JsonPropertyName("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// NACHA ACH return reason.
        /// </summary>
        [JsonProperty("return_reason")]
        [STJS.JsonPropertyName("return_reason")]
        public string ReturnReason { get; set; }
    }
}
