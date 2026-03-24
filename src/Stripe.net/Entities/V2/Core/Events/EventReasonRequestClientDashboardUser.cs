// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EventReasonRequestClientDashboardUser : StripeEntity<EventReasonRequestClientDashboardUser>
    {
        /// <summary>
        /// The email of the dashboard user.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// The IP address of the user.
        /// </summary>
        [JsonProperty("ip_address")]
        [STJS.JsonPropertyName("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// The machine identifier of the user.
        /// </summary>
        [JsonProperty("machine_identifier")]
        [STJS.JsonPropertyName("machine_identifier")]
        public string MachineIdentifier { get; set; }
    }
}
