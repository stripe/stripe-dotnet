// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsApiKeyManagedBy : StripeEntity<ActivityLogDetailsApiKeyManagedBy>
    {
        /// <summary>
        /// An application.
        /// </summary>
        [JsonProperty("application")]
        [STJS.JsonPropertyName("application")]
        public ActivityLogDetailsApiKeyManagedByApplication Application { get; set; }

        /// <summary>
        /// The type of entity.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
