// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsEventDestination : StripeEntity<ActivityLogDetailsEventDestination>
    {
        /// <summary>
        /// Configuration after the change. Set for added and updated actions, absent for removed
        /// actions.
        /// </summary>
        [JsonProperty("new_configuration")]
        [STJS.JsonPropertyName("new_configuration")]
        public ActivityLogDetailsEventDestinationNewConfiguration NewConfiguration { get; set; }

        /// <summary>
        /// Configuration before the change. Set for updated and removed actions, absent for added
        /// actions.
        /// </summary>
        [JsonProperty("old_configuration")]
        [STJS.JsonPropertyName("old_configuration")]
        public ActivityLogDetailsEventDestinationOldConfiguration OldConfiguration { get; set; }

        /// <summary>
        /// Type of the event destination.
        /// One of: <c>amazon_eventbridge</c>, <c>azure_event_grid</c>, or <c>webhook_endpoint</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
