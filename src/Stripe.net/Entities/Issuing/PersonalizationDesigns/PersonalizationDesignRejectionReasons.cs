// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PersonalizationDesignRejectionReasons : StripeEntity<PersonalizationDesignRejectionReasons>
    {
        /// <summary>
        /// The reason(s) the card logo was rejected.
        /// One of: <c>geographic_location</c>, <c>inappropriate</c>, <c>network_name</c>,
        /// <c>non_binary_image</c>, <c>non_fiat_currency</c>, <c>other</c>, <c>other_entity</c>, or
        /// <c>promotional_material</c>.
        /// </summary>
        [JsonProperty("card_logo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_logo")]
#endif

        public List<string> CardLogo { get; set; }

        /// <summary>
        /// The reason(s) the carrier text was rejected.
        /// One of: <c>geographic_location</c>, <c>inappropriate</c>, <c>network_name</c>,
        /// <c>non_fiat_currency</c>, <c>other</c>, <c>other_entity</c>, or
        /// <c>promotional_material</c>.
        /// </summary>
        [JsonProperty("carrier_text")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("carrier_text")]
#endif

        public List<string> CarrierText { get; set; }
    }
}
