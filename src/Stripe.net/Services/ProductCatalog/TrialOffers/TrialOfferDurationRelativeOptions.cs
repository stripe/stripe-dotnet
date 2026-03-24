// File generated from our OpenAPI spec
namespace Stripe.ProductCatalog
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TrialOfferDurationRelativeOptions : INestedOptions
    {
        /// <summary>
        /// The number of recurring price's interval to apply for the trial period.
        /// </summary>
        [JsonProperty("iterations")]
        [STJS.JsonPropertyName("iterations")]
        public long? Iterations { get; set; }
    }
}
