// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FrMealVouchersOnboardingProvidersConecs : StripeEntity<FrMealVouchersOnboardingProvidersConecs>
    {
        /// <summary>
        /// This represents information which issuers are available to this restaurant via Conecs.
        /// </summary>
        [JsonProperty("issuers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuers")]
#endif
        public FrMealVouchersOnboardingProvidersConecsIssuers Issuers { get; set; }

        /// <summary>
        /// This represents information about outstanding requirements for this restaurant to
        /// onboard to Conecs.
        /// </summary>
        [JsonProperty("requirements")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requirements")]
#endif
        public FrMealVouchersOnboardingProvidersConecsRequirements Requirements { get; set; }

        /// <summary>
        /// Status of the restaurant's onboarding to Conecs.
        /// One of: <c>action_required</c>, <c>active</c>, <c>disentitled</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
