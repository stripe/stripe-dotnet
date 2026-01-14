// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionRiskDetails : StripeEntity<RequestedSessionRiskDetails>
    {
        /// <summary>
        /// The risk metadata for the client device.
        /// </summary>
        [JsonProperty("client_device_metadata_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_device_metadata_details")]
#endif
        public RequestedSessionRiskDetailsClientDeviceMetadataDetails ClientDeviceMetadataDetails { get; set; }
    }
}
