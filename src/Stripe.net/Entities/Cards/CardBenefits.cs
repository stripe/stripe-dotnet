// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CardBenefits : StripeEntity<CardBenefits>
    {
        /// <summary>
        /// Issuer of this benefit card.
        /// </summary>
        [JsonProperty("issuer")]
        [STJS.JsonPropertyName("issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// Available benefit programs for this card.
        /// </summary>
        [JsonProperty("programs")]
        [STJS.JsonPropertyName("programs")]
        public List<string> Programs { get; set; }
    }
}
