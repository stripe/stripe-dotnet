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
        /// Whether the trial offer can be used for new subscriptions. Defaults to true.
        /// </summary>
        [JsonProperty("active")]
        [STJS.JsonPropertyName("active")]
        public bool? Active { get; set; }

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
        /// A brief description of the trial offer, hidden from customers.
        /// </summary>
        [JsonProperty("nickname")]
        [STJS.JsonPropertyName("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// Price configuration during the trial period (amount, billing scheme, etc).
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }
    }
}
