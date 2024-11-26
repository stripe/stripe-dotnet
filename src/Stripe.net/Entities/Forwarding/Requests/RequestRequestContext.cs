// File generated from our OpenAPI spec
namespace Stripe.Forwarding
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestRequestContext : StripeEntity<RequestRequestContext>
    {
        /// <summary>
        /// The time it took in milliseconds for the destination endpoint to respond.
        /// </summary>
        [JsonProperty("destination_duration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination_duration")]
#endif
        public long DestinationDuration { get; set; }

        /// <summary>
        /// The IP address of the destination.
        /// </summary>
        [JsonProperty("destination_ip_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination_ip_address")]
#endif
        public string DestinationIpAddress { get; set; }
    }
}
