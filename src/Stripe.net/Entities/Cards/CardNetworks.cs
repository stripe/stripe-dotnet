// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CardNetworks : StripeEntity<CardNetworks>
    {
        /// <summary>
        /// The preferred network for co-branded cards. Can be <c>cartes_bancaires</c>,
        /// <c>mastercard</c>, <c>visa</c> or <c>invalid_preference</c> if requested network is not
        /// valid for the card.
        /// </summary>
        [JsonProperty("preferred")]
        [STJS.JsonPropertyName("preferred")]
        public string Preferred { get; set; }
    }
}
