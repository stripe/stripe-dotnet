// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Code generated portion of V2 Event resource.
    /// </summary>
    public partial class Event : StripeEntity<Event>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the event.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Before and after changes for the primary related object.
        /// </summary>
        [JsonProperty("changes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("changes")]
#endif
        public Dictionary<string, object> Changes { get; set; }

        /// <summary>
        /// Authentication context needed to fetch the event or related object.
        /// </summary>
        [JsonProperty("context")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("context")]
#endif
        public string Context { get; set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Reason for the event.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public EventReason Reason { get; set; }

        /// <summary>
        /// The type of the event.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
