// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentQuoteEstimatedFeeNetworkFeeDetails : StripeEntity<OutboundPaymentQuoteEstimatedFeeNetworkFeeDetails>
    {
        /// <summary>
        /// The network associated with the fee.
        /// One of: <c>ach</c>, <c>becs</c>, <c>eft</c>, <c>fedwire</c>, <c>fps</c>, <c>local</c>,
        /// <c>npp</c>, <c>rtp</c>, <c>sepa</c>, <c>sepa_instant</c>, or <c>swift</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }

        /// <summary>
        /// Per-network options that affect the fee.
        /// </summary>
        [JsonProperty("network_options")]
        [STJS.JsonPropertyName("network_options")]
        public OutboundPaymentQuoteEstimatedFeeNetworkFeeDetailsNetworkOptions NetworkOptions { get; set; }
    }
}
