// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateDefaultsProfileOptions : INestedOptions
    {
        /// <summary>
        /// The business's publicly-available website.
        /// </summary>
        [JsonProperty("business_url")]
        [STJS.JsonPropertyName("business_url")]
        public string BusinessUrl { get; set; }

        /// <summary>
        /// The name which is used by the business.
        /// </summary>
        [JsonProperty("doing_business_as")]
        [STJS.JsonPropertyName("doing_business_as")]
        public string DoingBusinessAs { get; set; }

        /// <summary>
        /// Internal-only description of the product sold or service provided by the business. It's
        /// used by Stripe for risk and underwriting purposes.
        /// </summary>
        [JsonProperty("product_description")]
        [STJS.JsonPropertyName("product_description")]
        public string ProductDescription { get; set; }
    }
}
