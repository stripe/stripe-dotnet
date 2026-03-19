// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class VerificationSessionOptions : StripeEntity<VerificationSessionOptions>
    {
        [JsonProperty("document")]
        [STJS.JsonPropertyName("document")]
        public VerificationSessionOptionsDocument Document { get; set; }

        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public VerificationSessionOptionsEmail Email { get; set; }

        [JsonProperty("id_number")]
        [STJS.JsonPropertyName("id_number")]
        public VerificationSessionOptionsIdNumber IdNumber { get; set; }

        [JsonProperty("matching")]
        [STJS.JsonPropertyName("matching")]
        public VerificationSessionOptionsMatching Matching { get; set; }

        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public VerificationSessionOptionsPhone Phone { get; set; }
    }
}
