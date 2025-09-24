// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateDefaultsProfileOptions : INestedOptions
    {
        /// <summary>
        /// The business's publicly-available website.
        /// </summary>
        [JsonProperty("business_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("business_url")]
#endif
        public string BusinessUrl { get; set; }

        /// <summary>
        /// The name which is used by the business.
        /// </summary>
        [JsonProperty("doing_business_as")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("doing_business_as")]
#endif
        public string DoingBusinessAs { get; set; }

        /// <summary>
        /// Internal-only description of the product sold or service provided by the business. It's
        /// used by Stripe for risk and underwriting purposes.
        /// </summary>
        [JsonProperty("product_description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product_description")]
#endif
        public string ProductDescription { get; set; }
    }
}
