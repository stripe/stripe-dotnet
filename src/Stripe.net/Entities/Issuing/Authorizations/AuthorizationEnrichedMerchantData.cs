// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationEnrichedMerchantData : StripeEntity<AuthorizationEnrichedMerchantData>
    {
        /// <summary>
        /// Additional details about the seller (grocery store, e-commerce website, and so on) where
        /// the card authorization happened.
        /// </summary>
        [JsonProperty("merchant")]
        [STJS.JsonPropertyName("merchant")]
        public AuthorizationEnrichedMerchantDataMerchant Merchant { get; set; }

        /// <summary>
        /// An array of third parties involved in the card authorization, when applicable.
        /// </summary>
        [JsonProperty("third_parties")]
        [STJS.JsonPropertyName("third_parties")]
        public List<AuthorizationEnrichedMerchantDataThirdParty> ThirdParties { get; set; }
    }
}
