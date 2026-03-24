// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PersonalizationDesignPreferences : StripeEntity<PersonalizationDesignPreferences>
    {
        /// <summary>
        /// Whether we use this personalization design to create cards when one isn't specified. A
        /// connected account uses the Connect platform's default design if no personalization
        /// design is set as the default design.
        /// </summary>
        [JsonProperty("is_default")]
        [STJS.JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Whether this personalization design is used to create cards when one is not specified
        /// and a default for this connected account does not exist.
        /// </summary>
        [JsonProperty("is_platform_default")]
        [STJS.JsonPropertyName("is_platform_default")]
        public bool? IsPlatformDefault { get; set; }
    }
}
