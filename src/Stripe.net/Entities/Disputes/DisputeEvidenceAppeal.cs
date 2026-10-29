// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DisputeEvidenceAppeal : StripeEntity<DisputeEvidenceAppeal>
    {
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public DisputeEvidenceAppealCard Card { get; set; }
    }
}
