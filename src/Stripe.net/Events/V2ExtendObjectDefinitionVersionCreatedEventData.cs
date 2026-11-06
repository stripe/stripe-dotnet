// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2ExtendObjectDefinitionVersionCreatedEventData : StripeEntity<V2ExtendObjectDefinitionVersionCreatedEventData>
    {
        /// <summary>
        /// The singular API name of the object definition.
        /// </summary>
        [JsonProperty("api_name_singular")]
        [STJS.JsonPropertyName("api_name_singular")]
        public string ApiNameSingular { get; set; }

        /// <summary>
        /// The ID of the parent object definition.
        /// </summary>
        [JsonProperty("object_definition")]
        [STJS.JsonPropertyName("object_definition")]
        public string ObjectDefinition { get; set; }

        /// <summary>
        /// The semantic version of the created object definition version, in
        /// <c>major.minor.patch</c> format.
        /// </summary>
        [JsonProperty("version")]
        [STJS.JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
