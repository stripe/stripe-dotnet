// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class VerificationSessionRelatedPerson : StripeEntity<VerificationSessionRelatedPerson>
    {
        /// <summary>
        /// Token referencing the associated Account of the related Person resource.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// Token referencing the related Person resource.
        /// </summary>
        [JsonProperty("person")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("person")]
#endif
        public string Person { get; set; }
    }
}
