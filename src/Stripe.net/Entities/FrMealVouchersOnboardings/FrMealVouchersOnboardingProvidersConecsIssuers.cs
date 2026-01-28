// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FrMealVouchersOnboardingProvidersConecsIssuers : StripeEntity<FrMealVouchersOnboardingProvidersConecsIssuers>
    {
        /// <summary>
        /// Issuers are available to this restaurant via Conecs, will be blank if the onboarding to
        /// Conecs is not complete or unsuccessful.
        /// One of: <c>bimpli</c>, <c>edenred</c>, <c>pluxee</c>, or <c>up</c>.
        /// </summary>
        [JsonProperty("available")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("available")]
#endif
        public List<string> Available { get; set; }
    }
}
