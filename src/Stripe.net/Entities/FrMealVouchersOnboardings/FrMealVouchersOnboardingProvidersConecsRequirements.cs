// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FrMealVouchersOnboardingProvidersConecsRequirements : StripeEntity<FrMealVouchersOnboardingProvidersConecsRequirements>
    {
        /// <summary>
        /// Information any errors that are preventing the onboarding to Conecs from being
        /// completed.
        /// </summary>
        [JsonProperty("errors")]
        [STJS.JsonPropertyName("errors")]
        public List<FrMealVouchersOnboardingProvidersConecsRequirementsError> Errors { get; set; }

        /// <summary>
        /// Fields that need to be provided to complete the onboarding to Conecs.
        /// One of: <c>postal_code</c>, or <c>siret</c>.
        /// </summary>
        [JsonProperty("past_due")]
        [STJS.JsonPropertyName("past_due")]
        public List<string> PastDue { get; set; }
    }
}
