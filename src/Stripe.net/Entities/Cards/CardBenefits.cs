// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardBenefits : StripeEntity<CardBenefits>
    {
        /// <summary>
        /// Issuer of this benefit card.
        /// </summary>
        [JsonProperty("issuer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuer")]
#endif
        public string Issuer { get; set; }

        /// <summary>
        /// Available benefit programs for this card.
        /// </summary>
        [JsonProperty("programs")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("programs")]
#endif
        public List<string> Programs { get; set; }
    }
}
