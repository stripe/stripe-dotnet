// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class VerificationSessionOptions : StripeEntity<VerificationSessionOptions>
    {
        [JsonProperty("document")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("document")]
#endif
        public VerificationSessionOptionsDocument Document { get; set; }

        [JsonProperty("email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email")]
#endif
        public VerificationSessionOptionsEmail Email { get; set; }

        [JsonProperty("id_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_number")]
#endif
        public VerificationSessionOptionsIdNumber IdNumber { get; set; }

        [JsonProperty("phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone")]
#endif
        public VerificationSessionOptionsPhone Phone { get; set; }
    }
}
