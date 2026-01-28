// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FrMealVouchersOnboardingProvidersConecsRequirementsError : StripeEntity<FrMealVouchersOnboardingProvidersConecsRequirementsError>
    {
        /// <summary>
        /// The code for the type of error.
        /// One of: <c>postal_code_invalid</c>, or <c>siret_invalid</c>.
        /// </summary>
        [JsonProperty("code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("code")]
#endif
        public string Code { get; set; }

        /// <summary>
        /// An informative message that provides additional details about the error.
        /// </summary>
        [JsonProperty("message")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("message")]
#endif
        public string Message { get; set; }

        /// <summary>
        /// The specific onboarding requirement field (in the requirements hash) that needs to be
        /// resolved.
        /// One of: <c>postal_code</c>, or <c>siret</c>.
        /// </summary>
        [JsonProperty("requirement")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requirement")]
#endif
        public string Requirement { get; set; }
    }
}
