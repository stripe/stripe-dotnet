// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;

    public class EventDestinationStatusDetailsDisabled : StripeEntity<EventDestinationStatusDetailsDisabled>
    {
        /// <summary>
        /// Closed Enum. Reason event destination has been disabled.
        /// One of: <c>no_aws_event_source_exists</c>, or <c>user</c>.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
