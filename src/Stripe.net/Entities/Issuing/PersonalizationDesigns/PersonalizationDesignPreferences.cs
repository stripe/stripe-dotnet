// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class PersonalizationDesignPreferences : StripeEntity<PersonalizationDesignPreferences>
    {
        /// <summary>
        /// Whether this personalization design is used to create cards when one is not specified. A
        /// connected account will use the Connect platform's default if no personalization design
        /// is set as the account default.
        /// </summary>
        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Whether this personalization design is used to create cards when one is not specified
        /// and a default for this connected account does not exist.
        /// </summary>
        [JsonProperty("is_platform_default")]
        public bool? IsPlatformDefault { get; set; }
    }
}
