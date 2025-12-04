// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EventReasonRequestClientDashboardUser : StripeEntity<EventReasonRequestClientDashboardUser>
    {
        /// <summary>
        /// The email of the dashboard user.
        /// </summary>
        [JsonProperty("email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email")]
#endif
        public string Email { get; set; }

        /// <summary>
        /// The IP address of the user.
        /// </summary>
        [JsonProperty("ip_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ip_address")]
#endif
        public string IpAddress { get; set; }

        /// <summary>
        /// The machine identifier of the user.
        /// </summary>
        [JsonProperty("machine_identifier")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("machine_identifier")]
#endif
        public string MachineIdentifier { get; set; }
    }
}
