// File generated from our OpenAPI spec
namespace Stripe.Privacy
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RedactionJobValidationErrorErroringObject : StripeEntity<RedactionJobValidationErrorErroringObject>, IHasId
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Erroring object type.
        /// </summary>
        [JsonProperty("object_type")]
        [STJS.JsonPropertyName("object_type")]
        public string ObjectType { get; set; }
    }
}
