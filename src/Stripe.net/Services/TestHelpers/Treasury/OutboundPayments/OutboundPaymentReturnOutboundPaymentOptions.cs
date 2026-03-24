// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundPaymentReturnOutboundPaymentOptions : BaseOptions
    {
        /// <summary>
        /// Optional hash to set the return code.
        /// </summary>
        [JsonProperty("returned_details")]
        [STJS.JsonPropertyName("returned_details")]
        public OutboundPaymentReturnedDetailsOptions ReturnedDetails { get; set; }
    }
}
