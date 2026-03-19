// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FrMealVouchersOnboardingProviders : StripeEntity<FrMealVouchersOnboardingProviders>
    {
        /// <summary>
        /// This represents the onboarding state of the restaurant on Conecs.
        /// </summary>
        [JsonProperty("conecs")]
        [STJS.JsonPropertyName("conecs")]
        public FrMealVouchersOnboardingProvidersConecs Conecs { get; set; }
    }
}
