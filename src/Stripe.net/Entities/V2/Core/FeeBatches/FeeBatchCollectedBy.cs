// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FeeBatchCollectedBy : StripeEntity<FeeBatchCollectedBy>
    {
        /// <summary>
        /// The type of entity that collected this batch.
        /// One of: <c>application</c>, <c>network</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
