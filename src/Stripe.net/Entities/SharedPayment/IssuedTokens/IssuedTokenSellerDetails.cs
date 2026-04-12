// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IssuedTokenSellerDetails : StripeEntity<IssuedTokenSellerDetails>
    {
        /// <summary>
        /// A unique id within a network that identifies a logical seller. This should usually be
        /// the merchant id on the seller platform.
        /// </summary>
        [JsonProperty("external_id")]
        [STJS.JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// The unique and logical string that identifies the seller platform that this SharedToken
        /// is being created for.
        /// </summary>
        [JsonProperty("network_business_profile")]
        [STJS.JsonPropertyName("network_business_profile")]
        public string NetworkBusinessProfile { get; set; }
    }
}
