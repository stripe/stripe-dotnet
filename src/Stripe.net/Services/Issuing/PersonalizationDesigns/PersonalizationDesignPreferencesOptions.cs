// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class PersonalizationDesignPreferencesOptions : INestedOptions
    {
        /// <summary>
        /// Whether this personalization design is used to create cards when one is not specified. A
        /// connected account will use the Connect platform's default if no personalization design
        /// is set as default.
        /// </summary>
        [JsonProperty("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Only return the personalization design that is set as the Connect platform's default.
        /// This parameter is only applicable to connected accounts.
        /// </summary>
        [JsonProperty("is_platform_default")]
        public bool? IsPlatformDefault { get; set; }
    }
}
