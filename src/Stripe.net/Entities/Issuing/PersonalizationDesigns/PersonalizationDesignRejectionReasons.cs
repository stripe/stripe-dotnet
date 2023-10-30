// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PersonalizationDesignRejectionReasons : StripeEntity<PersonalizationDesignRejectionReasons>
    {
        /// <summary>
        /// The reason(s) the card logo was rejected.
        /// One of: <c>geographic_location</c>, <c>inappropriate</c>, <c>network_name</c>,
        /// <c>non_binary_image</c>, <c>non_fiat_currency</c>, <c>other</c>, <c>other_entity</c>, or
        /// <c>promotional_material</c>.
        /// </summary>
        [JsonProperty("card_logo")]
        public List<string> CardLogo { get; set; }

        /// <summary>
        /// The reason(s) the carrier text was rejected.
        /// One of: <c>geographic_location</c>, <c>inappropriate</c>, <c>network_name</c>,
        /// <c>non_fiat_currency</c>, <c>other</c>, <c>other_entity</c>, or
        /// <c>promotional_material</c>.
        /// </summary>
        [JsonProperty("carrier_text")]
        public List<string> CarrierText { get; set; }
    }
}
