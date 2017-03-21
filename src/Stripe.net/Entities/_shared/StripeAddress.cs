using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAddress : StripeEntity
    {
        /// <summary>
        /// City/District/Suburb/Town/Village.
        /// </summary>
        [JsonProperty("city")]
        public string CityOrTown { get; set; }

        /// <summary>
        /// 2-letter country code.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Address line 1 (Street address/PO Box/Company name).
        /// </summary>
        [JsonProperty("line1")]
        public string Line1 { get; set; }

        /// <summary>
        /// Address line 2 (Apartment/Suite/Unit/Building).
        /// </summary>
        [JsonProperty("line2")]
        public string Line2 { get; set; }

        /// <summary>
        /// Zip/Postal Code.
        /// </summary>
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// State/County/Province/Region.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }
    }
}
