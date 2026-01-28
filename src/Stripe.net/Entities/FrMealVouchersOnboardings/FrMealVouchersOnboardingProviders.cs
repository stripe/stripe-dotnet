// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FrMealVouchersOnboardingProviders : StripeEntity<FrMealVouchersOnboardingProviders>
    {
        /// <summary>
        /// This represents the onboarding state of the restaurant on Conecs.
        /// </summary>
        [JsonProperty("conecs")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("conecs")]
#endif
        public FrMealVouchersOnboardingProvidersConecs Conecs { get; set; }
    }
}
