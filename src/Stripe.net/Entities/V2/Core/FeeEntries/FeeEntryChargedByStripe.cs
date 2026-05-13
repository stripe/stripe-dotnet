// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FeeEntryChargedByStripe : StripeEntity<FeeEntryChargedByStripe>
    {
        /// <summary>
        /// Human-readable product name, e.g. "Card payments - Stripe fee".
        /// </summary>
        [JsonProperty("feature_name")]
        [STJS.JsonPropertyName("feature_name")]
        public string FeatureName { get; set; }
    }
}
