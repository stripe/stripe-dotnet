// File generated from our OpenAPI spec
namespace Stripe.ProductCatalog
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TrialOfferCreateOptions : BaseOptions
    {
        /// <summary>
        /// Duration of one service period of the trial.
        /// </summary>
        [JsonProperty("duration")]
        [STJS.JsonPropertyName("duration")]
        public TrialOfferDurationOptions Duration { get; set; }

        /// <summary>
        /// Define behavior that occurs at the end of the trial.
        /// </summary>
        [JsonProperty("end_behavior")]
        [STJS.JsonPropertyName("end_behavior")]
        public TrialOfferEndBehaviorOptions EndBehavior { get; set; }

        /// <summary>
        /// A brief, user-friendly name for the trial offer-for identification purposes.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Price configuration during the trial period (amount, billing scheme, etc).
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }
    }
}
