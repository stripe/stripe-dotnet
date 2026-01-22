// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FrMealVouchersOnboardingProvidersConecsRequirements : StripeEntity<FrMealVouchersOnboardingProvidersConecsRequirements>
    {
        /// <summary>
        /// Information any errors that are preventing the onboarding to Conecs from being
        /// completed.
        /// </summary>
        [JsonProperty("errors")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("errors")]
#endif
        public List<FrMealVouchersOnboardingProvidersConecsRequirementsError> Errors { get; set; }

        /// <summary>
        /// Fields that need to be provided to complete the onboarding to Conecs.
        /// One of: <c>postal_code</c>, or <c>siret</c>.
        /// </summary>
        [JsonProperty("past_due")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("past_due")]
#endif
        public List<string> PastDue { get; set; }
    }
}
