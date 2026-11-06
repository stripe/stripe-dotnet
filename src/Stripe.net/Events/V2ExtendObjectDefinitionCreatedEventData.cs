// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2ExtendObjectDefinitionCreatedEventData : StripeEntity<V2ExtendObjectDefinitionCreatedEventData>
    {
        /// <summary>
        /// The singular API name of the object definition.
        /// </summary>
        [JsonProperty("api_name_singular")]
        [STJS.JsonPropertyName("api_name_singular")]
        public string ApiNameSingular { get; set; }
    }
}
