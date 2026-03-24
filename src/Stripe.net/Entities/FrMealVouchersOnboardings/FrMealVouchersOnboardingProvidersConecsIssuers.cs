// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FrMealVouchersOnboardingProvidersConecsIssuers : StripeEntity<FrMealVouchersOnboardingProvidersConecsIssuers>
    {
        /// <summary>
        /// Issuers are available to this restaurant via Conecs, will be blank if the onboarding to
        /// Conecs is not complete or unsuccessful.
        /// One of: <c>bimpli</c>, <c>edenred</c>, <c>pluxee</c>, or <c>up</c>.
        /// </summary>
        [JsonProperty("available")]
        [STJS.JsonPropertyName("available")]
        public List<string> Available { get; set; }
    }
}
