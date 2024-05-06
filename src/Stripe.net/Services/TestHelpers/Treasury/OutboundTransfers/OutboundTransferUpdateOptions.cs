// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;

    public class OutboundTransferUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Details about network-specific tracking information.
        /// </summary>
        [JsonProperty("tracking_details")]
        public OutboundTransferTrackingDetailsOptions TrackingDetails { get; set; }
    }
}
