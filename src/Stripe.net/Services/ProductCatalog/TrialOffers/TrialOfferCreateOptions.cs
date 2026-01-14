// File generated from our OpenAPI spec
namespace Stripe.ProductCatalog
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TrialOfferCreateOptions : BaseOptions
    {
        /// <summary>
        /// Duration of one service period of the trial.
        /// </summary>
        [JsonProperty("duration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("duration")]
#endif
        public TrialOfferDurationOptions Duration { get; set; }

        /// <summary>
        /// Define behavior that occurs at the end of the trial.
        /// </summary>
        [JsonProperty("end_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("end_behavior")]
#endif
        public TrialOfferEndBehaviorOptions EndBehavior { get; set; }

        /// <summary>
        /// A brief, user-friendly name for the trial offer-for identification purposes.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// Price configuration during the trial period (amount, billing scheme, etc).
        /// </summary>
        [JsonProperty("price")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price")]
#endif
        public string Price { get; set; }
    }
}
