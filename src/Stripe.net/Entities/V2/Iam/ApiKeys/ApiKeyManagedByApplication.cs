// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ApiKeyManagedByApplication : StripeEntity<ApiKeyManagedByApplication>, IHasId
    {
        /// <summary>
        /// Identifier of the application.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
