// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSessionComponentsInstantPayoutsPromotionOptions : INestedOptions
    {
        /// <summary>
        /// Whether the embedded component is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The list of features enabled in the embedded component.
        /// </summary>
        [JsonProperty("features")]
        [STJS.JsonPropertyName("features")]
        public AccountSessionComponentsInstantPayoutsPromotionFeaturesOptions Features { get; set; }
    }
}
