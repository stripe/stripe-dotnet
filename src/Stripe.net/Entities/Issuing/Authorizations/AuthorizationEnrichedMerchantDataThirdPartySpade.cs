// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationEnrichedMerchantDataThirdPartySpade : StripeEntity<AuthorizationEnrichedMerchantDataThirdPartySpade>
    {
        /// <summary>
        /// Unified identifier for the third party.
        /// </summary>
        [JsonProperty("third_party_id")]
        [STJS.JsonPropertyName("third_party_id")]
        public string ThirdPartyId { get; set; }
    }
}
