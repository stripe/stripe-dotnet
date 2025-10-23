// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionRiskDetailsClientDeviceMetadataDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The radar session.
        /// </summary>
        [JsonProperty("radar_session")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("radar_session")]
#endif
        public string RadarSession { get; set; }

        /// <summary>
        /// The referrer of the client device.
        /// </summary>
        [JsonProperty("referrer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("referrer")]
#endif
        public string Referrer { get; set; }

        /// <summary>
        /// The remote IP address of the client device.
        /// </summary>
        [JsonProperty("remote_ip")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("remote_ip")]
#endif
        public string RemoteIp { get; set; }

        /// <summary>
        /// The time on page in seconds.
        /// </summary>
        [JsonProperty("time_on_page")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("time_on_page")]
#endif
        public long? TimeOnPage { get; set; }

        /// <summary>
        /// The user agent of the client device.
        /// </summary>
        [JsonProperty("user_agent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("user_agent")]
#endif
        public string UserAgent { get; set; }
    }
}
