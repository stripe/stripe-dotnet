// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundPaymentUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Details about network-specific tracking information.
        /// </summary>
        [JsonProperty("tracking_details")]
        [STJS.JsonPropertyName("tracking_details")]
        public OutboundPaymentTrackingDetailsOptions TrackingDetails { get; set; }
    }
}
