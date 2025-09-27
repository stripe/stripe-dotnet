// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EventDestinationStatusDetailsDisabled : StripeEntity<EventDestinationStatusDetailsDisabled>
    {
        /// <summary>
        /// Reason event destination has been disabled.
        /// One of: <c>no_aws_event_source_exists</c>, or <c>user</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }
    }
}
