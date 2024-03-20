// File generated from our OpenAPI spec
namespace Stripe.Forwarding
{
    using Newtonsoft.Json;

    public class RequestRequestContext : StripeEntity<RequestRequestContext>
    {
        /// <summary>
        /// The time it took in milliseconds for the destination endpoint to respond.
        /// </summary>
        [JsonProperty("destination_duration")]
        public long DestinationDuration { get; set; }

        /// <summary>
        /// The IP address of the destination.
        /// </summary>
        [JsonProperty("destination_ip_address")]
        public string DestinationIpAddress { get; set; }
    }
}
