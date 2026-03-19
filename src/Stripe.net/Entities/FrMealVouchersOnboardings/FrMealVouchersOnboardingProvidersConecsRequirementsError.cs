// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FrMealVouchersOnboardingProvidersConecsRequirementsError : StripeEntity<FrMealVouchersOnboardingProvidersConecsRequirementsError>
    {
        /// <summary>
        /// The code for the type of error.
        /// One of: <c>postal_code_invalid</c>, or <c>siret_invalid</c>.
        /// </summary>
        [JsonProperty("code")]
        [STJS.JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// An informative message that provides additional details about the error.
        /// </summary>
        [JsonProperty("message")]
        [STJS.JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// The specific onboarding requirement field (in the requirements hash) that needs to be
        /// resolved.
        /// One of: <c>postal_code</c>, or <c>siret</c>.
        /// </summary>
        [JsonProperty("requirement")]
        [STJS.JsonPropertyName("requirement")]
        public string Requirement { get; set; }
    }
}
