// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestedSessionRiskDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The client device metadata details for this requested session.
        /// </summary>
        [JsonProperty("client_device_metadata_details")]
        [STJS.JsonPropertyName("client_device_metadata_details")]
        public RequestedSessionRiskDetailsClientDeviceMetadataDetailsOptions ClientDeviceMetadataDetails { get; set; }
    }
}
