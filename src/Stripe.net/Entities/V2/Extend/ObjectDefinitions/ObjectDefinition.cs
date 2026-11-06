// File generated from our OpenAPI spec
namespace Stripe.V2.Extend
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Represents a user-defined object definition that models a custom object. Object
    /// definitions enable the object records API to create and manage records of that object.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ObjectDefinition : StripeEntity<ObjectDefinition>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object definition.
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
        /// The plural API name used in this definition's object record API paths. Immutable across
        /// versions.
        /// </summary>
        [JsonProperty("api_name_plural")]
        [STJS.JsonPropertyName("api_name_plural")]
        public string ApiNamePlural { get; set; }

        /// <summary>
        /// The singular API name used in the object tag of this definition's records. Immutable
        /// across versions.
        /// </summary>
        [JsonProperty("api_name_singular")]
        [STJS.JsonPropertyName("api_name_singular")]
        public string ApiNameSingular { get; set; }

        /// <summary>
        /// Time at which the object definition was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The ID of the latest object definition version.
        /// </summary>
        [JsonProperty("latest_version")]
        [STJS.JsonPropertyName("latest_version")]
        public string LatestVersion { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }
    }
}
