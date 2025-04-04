// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Details about network-specific tracking information.
        /// </summary>
        [JsonProperty("tracking_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tracking_details")]
#endif
        public OutboundPaymentTrackingDetailsOptions TrackingDetails { get; set; }
    }
}
