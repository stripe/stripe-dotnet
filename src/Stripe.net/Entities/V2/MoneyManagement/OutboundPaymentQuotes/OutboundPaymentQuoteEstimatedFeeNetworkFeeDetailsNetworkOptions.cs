// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentQuoteEstimatedFeeNetworkFeeDetailsNetworkOptions : StripeEntity<OutboundPaymentQuoteEstimatedFeeNetworkFeeDetailsNetworkOptions>
    {
        /// <summary>
        /// ACH-specific network fee options.
        /// </summary>
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public OutboundPaymentQuoteEstimatedFeeNetworkFeeDetailsNetworkOptionsAch Ach { get; set; }
    }
}
