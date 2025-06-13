// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class VerificationSessionRelatedPersonOptions : INestedOptions
    {
        /// <summary>
        /// A token representing a connected account. If provided, the person parameter is also
        /// required and must be associated with the account.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// A token referencing a Person resource that this verification is being used to verify.
        /// </summary>
        [JsonProperty("person")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("person")]
#endif
        public string Person { get; set; }
    }
}
