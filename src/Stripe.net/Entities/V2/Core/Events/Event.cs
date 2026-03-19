// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// Code generated portion of V2 Event resource.
    /// </summary>
    [NoSystemTextJsonAttributesNeeded("Converter is defined in Event.partial.cs")]
    public partial class Event : StripeEntity<Event>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the event.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Before and after changes for the primary related object.
        /// </summary>
        [JsonProperty("changes")]
        [STJS.JsonPropertyName("changes")]
        public Dictionary<string, object> Changes { get; set; }

        /// <summary>
        /// Authentication context needed to fetch the event or related object.
        /// </summary>
        [JsonProperty("context")]
        [STJS.JsonPropertyName("context")]
        public string Context { get; set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Reason for the event.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public EventReason Reason { get; set; }

        /// <summary>
        /// The type of the event.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
