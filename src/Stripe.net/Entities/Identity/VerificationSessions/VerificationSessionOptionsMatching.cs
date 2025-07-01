// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class VerificationSessionOptionsMatching : StripeEntity<VerificationSessionOptionsMatching>
    {
        /// <summary>
        /// Strictness of the DOB matching policy to apply.
        /// One of: <c>none</c>, or <c>similar</c>.
        /// </summary>
        [JsonProperty("dob")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dob")]
#endif
        public string Dob { get; set; }

        /// <summary>
        /// Strictness of the name matching policy to apply.
        /// One of: <c>none</c>, or <c>similar</c>.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }
    }
}
