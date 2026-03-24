// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FrMealVouchersOnboardingProvidersConecs : StripeEntity<FrMealVouchersOnboardingProvidersConecs>
    {
        /// <summary>
        /// This represents information which issuers are available to this restaurant via Conecs.
        /// </summary>
        [JsonProperty("issuers")]
        [STJS.JsonPropertyName("issuers")]
        public FrMealVouchersOnboardingProvidersConecsIssuers Issuers { get; set; }

        /// <summary>
        /// This represents information about outstanding requirements for this restaurant to
        /// onboard to Conecs.
        /// </summary>
        [JsonProperty("requirements")]
        [STJS.JsonPropertyName("requirements")]
        public FrMealVouchersOnboardingProvidersConecsRequirements Requirements { get; set; }

        /// <summary>
        /// Status of the restaurant's onboarding to Conecs.
        /// One of: <c>action_required</c>, <c>active</c>, <c>disentitled</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
