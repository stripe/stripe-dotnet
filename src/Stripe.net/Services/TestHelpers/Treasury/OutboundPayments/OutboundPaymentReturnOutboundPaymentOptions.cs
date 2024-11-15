// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentReturnOutboundPaymentOptions : BaseOptions
    {
        /// <summary>
        /// Optional hash to set the return code.
        /// </summary>
        [JsonProperty("returned_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("returned_details")]
#endif

        public OutboundPaymentReturnedDetailsOptions ReturnedDetails { get; set; }
    }
}
