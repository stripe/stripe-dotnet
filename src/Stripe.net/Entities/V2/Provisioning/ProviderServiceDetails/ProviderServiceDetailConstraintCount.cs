// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProviderServiceDetailConstraintCount : StripeEntity<ProviderServiceDetailConstraintCount>
    {
        [JsonProperty("at_most")]
        [STJS.JsonPropertyName("at_most")]
        public long AtMost { get; set; }
    }
}
