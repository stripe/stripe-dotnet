// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsStripeAccessReasonSupportRelationship : StripeEntity<ActivityLogDetailsStripeAccessReasonSupportRelationship>, IHasId
    {
        /// <summary>
        /// Identifier of the support relationship.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the support contact, when available.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Role of the support contact, when available.
        /// </summary>
        [JsonProperty("role")]
        [STJS.JsonPropertyName("role")]
        public string Role { get; set; }
    }
}
