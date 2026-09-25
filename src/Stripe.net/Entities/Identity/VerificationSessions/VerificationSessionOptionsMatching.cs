// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class VerificationSessionOptionsMatching : StripeEntity<VerificationSessionOptionsMatching>
    {
        /// <summary>
        /// Strictness of the DOB matching policy to apply.
        /// One of: <c>none</c>, or <c>similar</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("dob")]
        [STJS.JsonPropertyName("dob")]
        public string Dob { get; set; }

        /// <summary>
        /// Strictness of the name matching policy to apply.
        /// One of: <c>none</c>, or <c>similar</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
