// File generated from our OpenAPI spec
namespace Stripe.V2.Extend
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Represents an immutable version of an object definition. It defines the fields of the
    /// object records created from it.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ObjectDefinitionVersion : StripeEntity<ObjectDefinitionVersion>, IHasId, IHasObject
    {
        /// <summary>
        /// The complete version ID, consisting of the object definition ID, <c>@</c>, and a
        /// semantic version.
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
        /// Time at which the object definition version was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A description of what this version of the object definition represents.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The human-readable plural name of this version.
        /// </summary>
        [JsonProperty("display_name_plural")]
        [STJS.JsonPropertyName("display_name_plural")]
        public string DisplayNamePlural { get; set; }

        /// <summary>
        /// The human-readable singular name of this version.
        /// </summary>
        [JsonProperty("display_name_singular")]
        [STJS.JsonPropertyName("display_name_singular")]
        public string DisplayNameSingular { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The ID of the parent object definition.
        /// </summary>
        [JsonProperty("object_definition")]
        [STJS.JsonPropertyName("object_definition")]
        public string ObjectDefinition { get; set; }

        /// <summary>
        /// The stable identity and API names of the parent object definition.
        /// </summary>
        [JsonProperty("parent_details")]
        [STJS.JsonPropertyName("parent_details")]
        public ObjectDefinitionVersionParentDetails ParentDetails { get; set; }

        /// <summary>
        /// The schema of the object record fields defined by this object definition.
        /// </summary>
        [JsonProperty("properties")]
        [STJS.JsonPropertyName("properties")]
        public Dictionary<string, ObjectDefinitionVersionProperties> Properties { get; set; }

        /// <summary>
        /// The semantic version of this object definition version, in <c>major.minor.patch</c>
        /// format.
        /// </summary>
        [JsonProperty("version")]
        [STJS.JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
