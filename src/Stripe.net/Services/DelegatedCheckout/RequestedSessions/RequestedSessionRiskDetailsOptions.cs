// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionRiskDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The client device metadata details for this requested session.
        /// </summary>
        [JsonProperty("client_device_metadata_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_device_metadata_details")]
#endif
        public RequestedSessionRiskDetailsClientDeviceMetadataDetailsOptions ClientDeviceMetadataDetails { get; set; }
    }
}
