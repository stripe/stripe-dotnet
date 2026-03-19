// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionRiskDetails : StripeEntity<RequestedSessionRiskDetails>
    {
        /// <summary>
        /// The risk metadata for the client device.
        /// </summary>
        [JsonProperty("client_device_metadata_details")]
        [STJS.JsonPropertyName("client_device_metadata_details")]
        public RequestedSessionRiskDetailsClientDeviceMetadataDetails ClientDeviceMetadataDetails { get; set; }
    }
}
