// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PersonalizationDesignRejectionReasons : StripeEntity<PersonalizationDesignRejectionReasons>
    {
        /// <summary>
        /// The reason(s) the card logo was rejected.
        /// </summary>
        [JsonProperty("card_logo")]
        public List<string> CardLogo { get; set; }

        /// <summary>
        /// The reason(s) the carrier text was rejected.
        /// </summary>
        [JsonProperty("carrier_text")]
        public List<string> CarrierText { get; set; }
    }
}
