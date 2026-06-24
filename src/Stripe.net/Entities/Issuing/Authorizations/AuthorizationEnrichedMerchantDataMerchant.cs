// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationEnrichedMerchantDataMerchant : StripeEntity<AuthorizationEnrichedMerchantDataMerchant>
    {
        [JsonProperty("data_sources")]
        [STJS.JsonPropertyName("data_sources")]
        public List<string> DataSources { get; set; }

        [JsonProperty("industry")]
        [STJS.JsonPropertyName("industry")]
        public AuthorizationEnrichedMerchantDataMerchantIndustry Industry { get; set; }

        /// <summary>
        /// Location data of the seller.
        /// </summary>
        [JsonProperty("location")]
        [STJS.JsonPropertyName("location")]
        public AuthorizationEnrichedMerchantDataMerchantLocation Location { get; set; }

        /// <summary>
        /// Image link to the seller's logo.
        /// </summary>
        [JsonProperty("logo")]
        [STJS.JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// The name of the seller.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Phone number of the seller.
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// If <c>spade</c> is a data source, this hash contains details provided by Spade.
        /// </summary>
        [JsonProperty("spade")]
        [STJS.JsonPropertyName("spade")]
        public AuthorizationEnrichedMerchantDataMerchantSpade Spade { get; set; }

        /// <summary>
        /// URL of the seller's website.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
