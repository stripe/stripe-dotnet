// File generated from our OpenAPI spec
namespace Stripe.V2.Extend
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ObjectDefinitionVersionParentDetails : StripeEntity<ObjectDefinitionVersionParentDetails>, IHasId
    {
        /// <summary>
        /// The plural API name used in this definition's object record API paths.
        /// </summary>
        [JsonProperty("api_name_plural")]
        [STJS.JsonPropertyName("api_name_plural")]
        public string ApiNamePlural { get; set; }

        /// <summary>
        /// The singular API name used in this definition's object record tags.
        /// </summary>
        [JsonProperty("api_name_singular")]
        [STJS.JsonPropertyName("api_name_singular")]
        public string ApiNameSingular { get; set; }

        /// <summary>
        /// The ID of the parent object definition.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
