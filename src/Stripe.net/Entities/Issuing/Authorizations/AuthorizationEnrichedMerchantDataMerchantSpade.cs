// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationEnrichedMerchantDataMerchantSpade : StripeEntity<AuthorizationEnrichedMerchantDataMerchantSpade>
    {
        /// <summary>
        /// Unified identifier for the seller.
        /// </summary>
        [JsonProperty("counterparty_id")]
        [STJS.JsonPropertyName("counterparty_id")]
        public string CounterpartyId { get; set; }

        /// <summary>
        /// Unified identifier for the seller's location.
        /// </summary>
        [JsonProperty("location_id")]
        [STJS.JsonPropertyName("location_id")]
        public string LocationId { get; set; }
    }
}
