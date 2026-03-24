// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EventDestinationStatusDetailsDisabled : StripeEntity<EventDestinationStatusDetailsDisabled>
    {
        /// <summary>
        /// Reason event destination has been disabled.
        /// One of: <c>no_aws_event_source_exists</c>, <c>no_azure_partner_topic_exists</c>, or
        /// <c>user</c>.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
