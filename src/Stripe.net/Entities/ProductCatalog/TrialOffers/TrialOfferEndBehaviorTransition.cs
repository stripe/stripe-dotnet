// File generated from our OpenAPI spec
namespace Stripe.ProductCatalog
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TrialOfferEndBehaviorTransition : StripeEntity<TrialOfferEndBehaviorTransition>
    {
        /// <summary>
        /// The new price to use at the end of the trial offer period.
        /// </summary>
        [JsonProperty("price")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price")]
#endif
        public string Price { get; set; }
    }
}
