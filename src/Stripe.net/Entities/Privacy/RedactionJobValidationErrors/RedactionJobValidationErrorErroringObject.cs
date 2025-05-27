// File generated from our OpenAPI spec
namespace Stripe.Privacy
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RedactionJobValidationErrorErroringObject : StripeEntity<RedactionJobValidationErrorErroringObject>, IHasId
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// Erroring object type.
        /// </summary>
        [JsonProperty("object_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object_type")]
#endif
        public string ObjectType { get; set; }
    }
}
