// File generated from our OpenAPI spec
namespace Stripe.ProductCatalog
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TrialOfferDurationRelative : StripeEntity<TrialOfferDurationRelative>
    {
        /// <summary>
        /// The number of iterations of the price's interval for this trial offer.
        /// </summary>
        [JsonProperty("iterations")]
        [STJS.JsonPropertyName("iterations")]
        public long Iterations { get; set; }
    }
}
