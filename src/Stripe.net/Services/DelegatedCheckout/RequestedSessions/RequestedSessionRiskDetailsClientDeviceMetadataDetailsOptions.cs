// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestedSessionRiskDetailsClientDeviceMetadataDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The radar session.
        /// </summary>
        [JsonProperty("radar_session")]
        [STJS.JsonPropertyName("radar_session")]
        public string RadarSession { get; set; }

        /// <summary>
        /// The referrer of the client device.
        /// </summary>
        [JsonProperty("referrer")]
        [STJS.JsonPropertyName("referrer")]
        public string Referrer { get; set; }

        /// <summary>
        /// The remote IP address of the client device.
        /// </summary>
        [JsonProperty("remote_ip")]
        [STJS.JsonPropertyName("remote_ip")]
        public string RemoteIp { get; set; }

        /// <summary>
        /// The time on page in milliseconds.
        /// </summary>
        [JsonProperty("time_on_page_ms")]
        [STJS.JsonPropertyName("time_on_page_ms")]
        public long? TimeOnPageMs { get; set; }

        /// <summary>
        /// The user agent of the client device.
        /// </summary>
        [JsonProperty("user_agent")]
        [STJS.JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }
    }
}
