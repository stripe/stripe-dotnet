// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EventListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter for events created after the specified timestamp.
        /// </summary>
        [JsonProperty("created_gt")]
        public DateTime? CreatedGt { get; set; }

        /// <summary>
        /// Filter for events created at or after the specified timestamp.
        /// </summary>
        [JsonProperty("created_gte")]
        public DateTime? CreatedGte { get; set; }

        /// <summary>
        /// Filter for events created before the specified timestamp.
        /// </summary>
        [JsonProperty("created_lt")]
        public DateTime? CreatedLt { get; set; }

        /// <summary>
        /// Filter for events created at or before the specified timestamp.
        /// </summary>
        [JsonProperty("created_lte")]
        public DateTime? CreatedLte { get; set; }

        /// <summary>
        /// Filter events based on whether they were successfully delivered to all subscribed event
        /// destinations. If false, events which are still pending or have failed all delivery
        /// attempts to a event destination will be returned.
        /// </summary>
        [JsonProperty("delivery_success")]
        public bool? DeliverySuccess { get; set; }

        /// <summary>
        /// Primary object ID used to retrieve related events.
        /// </summary>
        [JsonProperty("object_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object_id")]
#endif
        public string ObjectId { get; set; }

        /// <summary>
        /// The requested page.
        /// </summary>
        [JsonProperty("page")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("page")]
#endif
        public string Page { get; set; }
    }
}
