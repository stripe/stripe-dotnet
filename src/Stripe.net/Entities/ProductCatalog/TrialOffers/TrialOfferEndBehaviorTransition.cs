// File generated from our OpenAPI spec
namespace Stripe.ProductCatalog
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TrialOfferEndBehaviorTransition : StripeEntity<TrialOfferEndBehaviorTransition>
    {
        /// <summary>
        /// The new price to use at the end of the trial offer period.
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }
    }
}
