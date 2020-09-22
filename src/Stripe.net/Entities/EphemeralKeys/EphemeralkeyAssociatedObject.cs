// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class EphemeralKeyAssociatedObject : StripeEntity<EphemeralKeyAssociatedObject>, IHasId
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
